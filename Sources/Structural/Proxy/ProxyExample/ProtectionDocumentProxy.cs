namespace ProxyExample;

/// <summary>
/// Proxy
/// </summary>
public class ProtectionDocumentProxy : IDocument
{
    private string _fileName;
    private string _userRole;
    private VirtualDocumentProxy _virtualDocumentProxy;

    public ProtectionDocumentProxy(string fileName, string userRole)
    {
        _fileName = fileName;
        _userRole = userRole;
        _virtualDocumentProxy = new VirtualDocumentProxy(_fileName);
    }

    public void DisplayDocument()
    {
        Console.WriteLine($"Entering DisplayDocument " +
                          $"in {nameof(ProtectionDocumentProxy)}.");

        if (_userRole != "Viewer")
        {
            throw new UnauthorizedAccessException();
        }
        
        _virtualDocumentProxy.DisplayDocument();

        Console.WriteLine($"Exiting DisplayDocument " +
                          $"in {nameof(ProtectionDocumentProxy)}.");
    }
}