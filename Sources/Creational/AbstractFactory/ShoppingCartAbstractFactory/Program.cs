using ShoppingCartAbstractFactory;

Console.Title = "Abstract Factory";

Console.Write("Shopping cart for Belgium: ");
var belgiumShoppingCartPurchaseFactory = new BelgiumShoppingCartPurchaseFactory();
var shoppingCartForBelgium = new ShoppingCart(belgiumShoppingCartPurchaseFactory);
shoppingCartForBelgium.CalculateCosts();

Console.Write("Shopping cart for France: ");
var franceShoppingCartPurchaseFactory = new FranceShoppingCartPurchaseFactory();
var shoppingCartForFrance = new ShoppingCart(franceShoppingCartPurchaseFactory);
shoppingCartForFrance.CalculateCosts();

Console.ReadKey();