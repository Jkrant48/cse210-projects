

public class Address
{
    private string _city;
    private string _stateProvince;
    private string _country;
    private string _streetAddress;

    public Address(string city, string stateProvince, string country, string streetAddress)
    {
        _city = city;
        _country = country;
        _stateProvince = stateProvince;
        _streetAddress = streetAddress;
    }

    public bool IsUSA()
    {
        if (_country == "USA")
        {
            result = true;
        }
        else
        {
            result = false;
        }
        return result;
    }

    public string GetFullAddress()
    {
        return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
    }
}