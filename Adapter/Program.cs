using Adapter; // using object adapter example
/*using ClassAdapter; // using class adapter example*/

Console.Title = "Adapter";

ICityAdapter adapter = new CityAdapter();
var city = adapter.GetCity();

Console.WriteLine($"{city.FullName}, {city.Inhabitants}");
Console.ReadKey();