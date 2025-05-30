using System;

public class Customer
{
    //----Member Attributes----
    private string _customerName;
    private Address _customerAddress;



    //----Constructor----
    public Customer(string name, Address address)
    {
        _customerName = name;
        _customerAddress = address;
    }


    //----Methods----

    //Determine if the customer is in the USA
    public Boolean isCustomerUSA()
    {
        Boolean customerUSA;
        if (_customerAddress.isUSA() == true)
        {
            customerUSA = true;
        }
        else
        {
            customerUSA = false;
        }
        return customerUSA;
    }

    //Method to access name and address for each customer when creating shipping labels
    public string ShippingLabelInfo()
    {
        return $"{_customerName}\n{_customerAddress.CreateAddress()}";
    }
}