public class Customer
{
    private string _name;
    private Address _address;

    public Customer (string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool isUSA()
    {
        return _address.isUSA() ? true : false;
    }

    public string GetName()
    {
        return _name;
    }
    public string GetAddress()
    {
        string getAddress = _address.GetAddress();
        return getAddress;
    }
}