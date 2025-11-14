namespace CityAdapterExample;

/// <summary>
/// Our city representation we use
/// </summary>
public class City
{
    public string FullName { get; private set; }
    public long Inhabitants { get; private set; }

    public City(string fullName, long inhabitants)
    {
        FullName = fullName;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// External city we can't really use
/// </summary>
public class CityFromExternalSystem
{
    public string Name { get; private set; }
    public string NickName { get; private set; }
    public int Inhabitants { get; private set; }

    public CityFromExternalSystem(string name, string nickName, int inhabitants)
    {
        Name = name;
        NickName = nickName;
        Inhabitants = inhabitants;
    }
}

/// <summary>
/// Adaptee (Legacy system, which we want to adapt)
/// </summary>
public class ExternalSystem
{
    public CityFromExternalSystem GetCity()
    {
        return new CityFromExternalSystem("Antwerp", "'t Stad", 500000);
    }
}

/// <summary>
/// Target
/// </summary>
public interface ICityAdapter
{
    City GetCity();
}

/// <summary>
/// Adapter
/// </summary>
public class CityAdapter: ICityAdapter
{
    private ExternalSystem ExternalSystem { get; set; } = new();
    
    public City GetCity()
    {
        // call into the external system
        var cityFromExternalSystem = ExternalSystem.GetCity();
        
        // adapt the CityFromExternalCity to a City
        return new City(
            $"{cityFromExternalSystem.Name} - {cityFromExternalSystem.NickName}",
            cityFromExternalSystem.Inhabitants);
    }
}