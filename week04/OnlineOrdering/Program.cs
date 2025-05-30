using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        //Create variables for order
        Address order1Address = new Address("105 Bramble Ln", "Detroit", "MI", "USA");
        Customer order1Customer = new Customer("Cutting Edge", order1Address);
        List<Product> order1Products = new List<Product>();
        //Create new Order
        Order order1 = new Order(order1Customer, order1Products);
        //Add products to the order
        Product order1Product1 = new Product("scissors", 10663, 5.35, 10);
        Product order1Product2 = new Product("paper cutters", 65898, 15.20, 2);
        order1Products.Add(order1Product1);
        order1Products.Add(order1Product2);

        //Display Results
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.CreatePackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.CreateShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost of Order: ${order1.CalculateOrderTotal():F2}");
        Console.WriteLine();


        //Order 2
        //Create variables for order
        Address order2Address = new Address("234 Center Circle", "Bath", "Somerset", "United Kingdom");
        Customer order2Customer = new Customer("Bath Bounties", order2Address);
        List<Product> order2Products = new List<Product>();
        //Create new Order
        Order order2 = new Order(order2Customer, order2Products);
        //Add products to the order
        Product order2Product1 = new Product("paper", 45632, 7, 15);
        Product order2Product2 = new Product("office chairs", 78965, 64.75, 5);
        order2Products.Add(order2Product1);
        order2Products.Add(order2Product2);

        //Display Results
        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.CreatePackingLabel());
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.CreateShippingLabel());
        Console.WriteLine();
        Console.WriteLine($"Total Cost of Order: ${order2.CalculateOrderTotal():F2}");
        Console.WriteLine();



    }
}