namespace ShoppingCartAbstractFactory;

/// <summary>
/// Abstract factory
/// </summary>
public interface IShoppingCartPurchaseFactory
{
   IDiscountService CreateDiscountService();
   IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// Abstract product. (ProductA)
/// </summary>
public interface IDiscountService
{
   int DiscountPercentage { get; }
}

/// <summary>
/// Abstract product. (ProductB)
/// </summary>
public interface IShippingCostsService
{
   decimal ShippingCosts { get; }
}