using ProxyExample;

Console.Title = "Proxy";

// without proxy
Console.WriteLine("Constructing document.");
var myDocument = new Document("MyDocument.pdf");
Console.WriteLine("Document constructed.");
myDocument.DisplayDocument();

Console.WriteLine();

// with lazy loading
Console.WriteLine("Constructing document proxy.");
var myDocumentProxy = new VirtualDocumentProxy("MyDocument.pdf");
Console.WriteLine("Document proxy constructed.");
myDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxy (lazy loading and access control)
Console.WriteLine("Constructing protected document proxy.");
var myProtectedDocumentProxy = new ProtectionDocumentProxy("MyDocument.pdf", "Viewer");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();

Console.WriteLine();

// with chained proxy, no access
Console.WriteLine("Constructing protected document proxy.");
myProtectedDocumentProxy = new ProtectionDocumentProxy("MyDocument.pdf", "AnotherRole");
Console.WriteLine("Protected document proxy constructed.");
myProtectedDocumentProxy.DisplayDocument();

Console.ReadKey();