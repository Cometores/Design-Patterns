namespace FoodMenuBridge;

/// <summary>
/// Abstraction
/// </summary>
public abstract class Menu
{
    protected readonly ICoupon Coupon = null!;
    public abstract int CalculatePrice();

    protected Menu(ICoupon coupon)
    {
        Coupon = coupon;
    }
}

/// <summary>
/// Refined abstraction 1
/// </summary>
public class VegetarianMenu : Menu
{
    public VegetarianMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 20 - Coupon.CouponValue;
    }
}

/// <summary>
/// Refined abstraction 2
/// </summary>
public class MeatBasedMenu : Menu
{
    public MeatBasedMenu(ICoupon coupon) : base(coupon)
    {
    }

    public override int CalculatePrice()
    {
        return 30 - Coupon.CouponValue;
    }
}

/// <summary>
/// Implementor
/// </summary>
public interface ICoupon
{
    int CouponValue { get; }
}

/// <summary>
/// Concrete implementor 1
/// </summary>
public class NoCoupon : ICoupon
{
    public int CouponValue => 0;
}

/// <summary>
/// Concrete implementor 2
/// </summary>
public class OneEuroCoupon : ICoupon
{
    public int CouponValue => 1;
}

/// <summary>
/// Concrete implementor 3
/// </summary>
public class TwoEuroCoupon : ICoupon
{
    public int CouponValue => 2;
}