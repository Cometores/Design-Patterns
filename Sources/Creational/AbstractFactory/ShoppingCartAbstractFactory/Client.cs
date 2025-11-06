namespace ShoppingCartAbstractFactory;

/// <summary>
/// Client class
/// </summary>
public class ShoppingCart
{
    private const int ORDER_COSTS = 200;

    private readonly IDiscountService _discountService;
    private readonly IShippingCostsService _shippingCostsService;

    public ShoppingCart(IShoppingCartPurchaseFactory factory)
    {
        _discountService = factory.CreateDiscountService();
        _shippingCostsService = factory.CreateShippingCostsService();
    }

    /// <summary>
    /// Calculates the total cost of an order, including applying a discount and adding shipping costs.
    /// </summary>
    public void CalculateCosts()
    {
        Console.WriteLine($"Total costs = " +
                          $"{ORDER_COSTS - (ORDER_COSTS / 100 * _discountService.DiscountPercentage) + _shippingCostsService.ShippingCosts}");
    }
}