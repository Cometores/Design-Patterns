namespace ShoppingCartAbstractFactory;

/// <summary>
/// Concrete product A for Belgium. (ProductA1)
/// </summary>
public class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

/// <summary>
/// Concrete product for Belgium. (ProductA2)
/// </summary>
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// Concrete product B for Belgium. (ProductB1)
/// </summary>
public class BelgiumShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}

/// <summary>
/// Concrete product B for France. (ProductB2)
/// </summary>
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
}