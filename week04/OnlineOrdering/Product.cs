using System;

public class Product
{
    //----Member Attributes----
    private string _productName;
    private int _productID;
    private double _productPrice;
    private int _productQuantity;

    //----Constructor----
    public Product(string name, int ID, double price, int quantity)
    {
        _productName = name;
        _productID = ID;
        _productPrice = price;
        _productQuantity = quantity;
    }

    //----Method----

    //Calculate the total cost for each product
    public double TotalProductCost()
    {
        double totalProductCost = _productPrice * _productQuantity;
        return totalProductCost;
    }

    //Method to access information for packing label creation in Order Class
    public string PackingLabelInfo()
    {
        return $"{_productName} : {_productID}\n";
    }
}