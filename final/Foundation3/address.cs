

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateprovince;
    private string _country;

    public Address(string streetAddress, string city, string stateprovince, string country)
    {
        _city = city;
        _country = country;
        _stateprovince = stateprovince;
        _streetAddress = streetAddress;
    }

    public string DisplayAddress()
    {
        return $"{_streetAddress}, {_city}, {_stateprovince}, {_country}.";
    }
}