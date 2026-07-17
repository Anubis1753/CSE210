public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode)
    {
        _street = street;
        _city = city;
        _state = street;
        _zipCode = zipCode;
    }

    public string FullAddress()
    {
        return $"{_street}, {_city}, {_state} {_zipCode}";
    }
}