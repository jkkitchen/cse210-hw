using System;

public class Address
{
    //----Member Attributes----
    private string _street;
    private string _city;
    private string _state;
    private string _country;


    //----Constructor----
    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }


    //----Methods----

    //Determine if the shipping location is in the USA
    public Boolean isUSA()
    {
        Boolean isCountryUSA;
        if (_country == "USA" || _country == "United States of America")
        {
            isCountryUSA = true;
        }
        else
        {
            isCountryUSA = false;
        }

        return isCountryUSA;
    }

    //Create the Address to be used in other classes
    public string CreateAddress()
    {
        string address = $"{_street}\n{_city}, {_state}\n{_country}";
        return address;
    }
}