namespace ProxyExample;

/// <summary>
/// Proxy
/// </summary>
public class VirtualDocumentProxy : IDocument
{
    // avoid creating the document until we need it
    private Lazy<Document> _document;
    private string _fileName;

    public VirtualDocumentProxy(string fileName)
    {
        _fileName = fileName;
        _document = new Lazy<Document>(() => new Document(_fileName));
    }
        
    public void DisplayDocument()
    {
        _document.Value.DisplayDocument();
    }
}