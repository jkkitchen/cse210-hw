using System;
using System.Reflection.Emit;

public class Order
{
    //----Member Attributes----
    private Customer _orderCustomer;
    private List<Product> _orderProducts;


    //----Constructor----
    public Order(Customer customer, List<Product> products)
    {
        _orderCustomer = customer;
        _orderProducts = products;
    }

    //----Methods----

    //Calculate the total cost of the order
    public double CalculateOrderTotal()
    {
        //Define variables for if statements and loops        
        double shippingCost;
        double totalProductCost = 0;

        //Calculate shipping
        if (_orderCustomer.isCustomerUSA() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }

        //Calculate total for products using a loop
        foreach (Product product in _orderProducts)
        {
            double productCost = product.TotalProductCost();
            totalProductCost += productCost;
        }

        //Calculate and return the total
        double totalOrderCost = shippingCost + totalProductCost;
        return totalOrderCost;
    }


    //Create Packing Label
    public string CreatePackingLabel()
    {
        //Create variable
        string packingLabel = "";

        //Iterate through the list of products and return the name and ID for each product
        foreach (Product product in _orderProducts)
        {
            packingLabel += product.PackingLabelInfo();
        }

        //Return the Packing Label
        return packingLabel;
    }

    //Create Shipping Label
    public string CreateShippingLabel()
    {
        string shippingLabel = _orderCustomer.ShippingLabelInfo();
        return shippingLabel;
    }
}
