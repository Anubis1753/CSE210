public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProcuct(Product product)
    {
        _productList.Add(product);
    }

    public double ProductsTotal()
    {
        double subtotal = 0;

        foreach(Product p in _productList)
        {
            subtotal += p.TotalValue();
        }

        double shippingCost;

        if (_customer.IsInUS())
        {
            shippingCost = 5.0;
        }
        else
        {
            shippingCost = 35.0;
        }

        return subtotal + shippingCost;
    }
    
    public string MakePackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product p in _productList)
        {
            label = label + $"Product: {p.GetName()} (ID: {p.GetId()})\n";
        }
        return label;
    }

    public string MakeShipingLabel()
    {
        return "Shipping Label:\n" + _customer.GetName() + "\n" + _customer.GetAddress().GetOrderedAdress();
    }
}