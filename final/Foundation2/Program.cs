using System;

class Program
{
    static void Main(string[] args)
    {
        Address A1 = new Address("542 Wemblton way", "Flagstaff", "AZ", "USA");
        Customer C1 = new Customer("Jack Smith", A1);
        Order O1 = new Order(C1);
        O1.AddProcuct(new Product("Computer", "FL015", 2000.00, 1));
        O1.AddProcuct(new Product("Keyboard", "T1684Y", 250.00, 1));

        Address A2 = new Address("846 Carlton St.", "Paris", "IDF", "France");
        Customer C2 = new Customer("August Johnson", A2);
        Order O2 = new Order(C2);
        O2.AddProcuct(new Product("Washing Mechine", "DO823L", 300.00, 1));
        O2.AddProcuct(new Product("Dish Set", "CR953M", 50.00, 1));

        DisplayOrder(O1);
        DisplayOrder(O2);
    }

    public static void DisplayOrder(Order order)
    {
        Console.WriteLine(order.MakePackingLabel());
        Console.WriteLine(order.MakeShipingLabel());
        Console.WriteLine($"Total Price: {order.ProductsTotal():F2}");
        Console.WriteLine("---------------------------------------");
    }
}