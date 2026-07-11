public class Product
{
    string _name;
    string _id;
    double _pricePerUnit;
    int _quantity;

    public Product(string name, string id, double pricePerUnit, int quantity)
    {
        _name = name;
        _id = id;
        _pricePerUnit = pricePerUnit;
        _quantity = quantity;
    }

    public string GetName()
    {
        return _name;
    }

    public string GetId()
    {
        return _id;
    }

    public double TotalValue()
    {
        return _pricePerUnit * _quantity;
    }
}