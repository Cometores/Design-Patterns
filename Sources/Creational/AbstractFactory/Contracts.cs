namespace AbstractFactory;

/// <summary>
/// AbstractFactory
/// </summary>
public interface IShoppingCartPurchaseFactory
{
   IDiscountService CreateDiscountService();
   IShippingCostsService CreateShippingCostsService();
}

/// <summary>
/// AbstractProduct
/// </summary>
public interface IDiscountService
{
   int DiscountPercentage { get; }
}

/// <summary>
/// AbstractProduct
/// </summary>
public interface IShippingCostsService
{
   decimal ShippingCosts { get; }
}