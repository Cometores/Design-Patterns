namespace CarBuilder;

/// <summary>
/// Director
/// </summary>
public class Garage
{
    private CarBuilder? _builder;

    /// <summary>
    /// Creates a car using the specified builder.
    /// </summary>
    public void Construct(CarBuilder builder)
    {
        _builder = builder;
        
        _builder.BuildEngine();
        _builder.BuildFrame();
    }

    /// <summary>
    /// Displays the details of the constructed car.
    /// </summary>
    public void Show()
    {
        Console.WriteLine(_builder?.Car.ToString());
    }
}