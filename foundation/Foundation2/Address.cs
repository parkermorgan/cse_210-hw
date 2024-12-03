public class Address 
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address (string streetAddress, string city, string state, string country)
    {
        _street = streetAddress;
        _city = city;
        _state = state;
        _country = country;

    }

    public bool isUSA()
    {
        return _country == "USA" ? true : false;
    }

    public string GetAddress()
    {
        string address = $"{_street}, {_city}, {_state}, {_country}";
        return address;
    }
}