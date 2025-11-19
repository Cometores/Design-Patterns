using TemplateMethodExample;

Console.Title = "Template Method";

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("exchange"));
Console.WriteLine();

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("apache"));
Console.WriteLine();

EudoraMailParser eudoraMailParser = new ();
Console.WriteLine(eudoraMailParser.ParseMailBody("eudora"));

Console.ReadKey();