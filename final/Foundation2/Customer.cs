using System;

class Customer
{
    // attributes
    private string _customerName;
    private Address _address;

    // constructor
    public Customer(string customerName, Address address)
    {
        _customerName = customerName;
        _address = address;
    }

    // method to set and return if customer is from USA
    public bool IsUSACustomer()
    {
        if (_address.IsUSAAddress() == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // method to return combined customer name and address
    public void CustomerAddress()
    {
        Console.WriteLine($"{_customerName}");
        _address.ConstructAddress();
    }
}