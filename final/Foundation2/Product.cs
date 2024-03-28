using System;

class Product
{
    // attributes
    private string _productName;
    private string _productID;
    private double _price;
    private int _quantity;

    // constructor
    public Product(string productName, string productID, double price, int quantity)
    {
        _productName = productName;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // method to get product name
    public string ProductName()
    {
        return _productName;
    }

    // method to get product ID
    public string ProductID()
    {
        return _productID;
    }

    // method to calculate total cost
    public double ProductCost()
    {
        return _price * _quantity;
    }
}