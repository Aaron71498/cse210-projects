using System;

class Program
{
    static void Main(string[] args)
    {
        // list of orders
        List<Order> orders = new List<Order>();

        // 1st order creation
        // address
        Address a1 = new Address("3109 Setting Sun Ct.", "Crestwood", "Kentucky", "USA");
        // customer
        Customer c1 = new Customer("Bob Red", a1);
        // order
        Order o1 = new Order(c1);
        // product 1
        Product o1p1 = new Product("socks", "00000111", 7.56, 10);
        // product 2
        Product o1p2 = new Product("shoes", "00001110", 14.32, 1);
        // product 3
        Product o1p3 = new Product("underwear", "00011100", 5.55, 10);
        // add products to order
        o1.AddProduct(o1p1);
        o1.AddProduct(o1p2);
        o1.AddProduct(o1p3);
        // add order to orders list
        orders.Add(o1);

        // 2nd order creation
        // address
        Address a2 = new Address("4012 Blackthorn Pl.", "La Grange", "kentucky", "USA");
        // customer
        Customer c2 = new Customer("Bear McGruffin", a2);
        // order
        Order o2 = new Order(c2);
        // product 1
        Product o2p1 = new Product("bubble bath", "00111000", 3.99, 1);
        // product 2
        Product o2p2 = new Product("bath salts", "01110000", 10.98, 2);
        // product 3
        Product o2p3 = new Product("toaster", "11100000", 14.99, 1);
        // add products to order
        o2.AddProduct(o2p1);
        o2.AddProduct(o2p2);
        o2.AddProduct(o2p3);
        // add order to orders list
        orders.Add(o2);

        // print info for each order
        foreach (Order order in orders)
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------"); // buffer line
            Console.WriteLine("Packing Label:");
            order.PackingLabel();
            Console.WriteLine(); // blank line
            Console.WriteLine("Shipping Label:");
            order.ShippingLabel();
            Console.WriteLine(); // blank line
            Console.WriteLine($"Total Price: ${order.OrderCost().ToString("0.00")}");
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------"); // buffer line
    }
}