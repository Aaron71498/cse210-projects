using System;

class Address
{
    // attributes
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    // consctructor
    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    // method to return if address is from USA
    public bool IsUSAAddress()
    {
        if (_country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // method to return complete address
    public void ConstructAddress()
    {
        Console.WriteLine($"{_streetAddress}");
        Console.WriteLine($"{_city}, {_state}, {_country}");
    }
}