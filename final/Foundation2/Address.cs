public class Address
{
    private string _streetAdress;
    string _city;
    string _state;
    string _country;

    public Address(string streetAdress, string city, string state, string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _state = state;
        _country = country;
    }

    public bool IsInUS()
    {
        return _country.ToUpper() == "USA";
    }

    public string GetOrderedAdress()
    {
        return $"{_streetAdress}\n{_city}, {_state}\n{_country}";
    }
}