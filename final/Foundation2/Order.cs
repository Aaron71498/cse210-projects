using System;

class Order
{
    // attributes
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    // constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // method to add to products list
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // method to calculate total cost of order plus shipping
    public double OrderCost()
    {
        double total = 0;

        // cost of products
        foreach (Product product in _products)
        {
            total += product.ProductCost();
        }

        // shipping cost
        if (_customer.IsUSACustomer() == true)
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        // return total cost
        return total;
    }

    // method to create packing label
    public void PackingLabel()
    {
        foreach (Product product in _products)
        {
            Console.WriteLine($"{product.ProductID()} - {product.ProductName()}");
        }
    }


    // method to create shipping label
    public void ShippingLabel()
    {
        _customer.CustomerAddress();
    }
}