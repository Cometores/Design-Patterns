namespace AbstractFactory;

/// <summary>
/// ConcreteProduct
/// </summary>
public class BelgiumDiscountService : IDiscountService
{
    public int DiscountPercentage => 20;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class FranceDiscountService : IDiscountService
{
    public int DiscountPercentage => 10;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class BelgiumShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 20;
}

/// <summary>
/// ConcreteProduct
/// </summary>
public class FranceShippingCostsService : IShippingCostsService
{
    public decimal ShippingCosts => 25;
}