using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //First order
        Product p1 = new Product("product1", "353535", 2, 3.5F);
        Product p2 = new Product("product2", "353536", 2, 3.0F);
        Product p3 = new Product("product3", "353537", 2, 2.5F);

        Address a1 = new Address("Bassols", "Barcelona", "Barcelona", "España");
        Customer c1 = new Customer("Dorian", a1);
        
        List<Product> products = new List<Product>()
        {
            p1,p2,p3
        };
        Order o1 = new Order(products, c1);

        //Secod Order
        Product p21 = new Product("product1", "353535", 2, 3.5F);
        Product p22 = new Product("product2", "353536", 2, 3.0F);
        Product p23 = new Product("product3", "353537", 2, 2.5F);

        Address a2 = new Address("Bassols", "Barcelona", "Barcelona", "USA");
        Customer c2 = new Customer("Dorian2", a2);

        List<Product> products2 = new List<Product>()
        {
            p21,p22,p23
        };
        Order o2 = new Order(products2, c2);

        //Second Order
        Product p31 = new Product("product1", "353535", 2, 3.5F);
        Product p32 = new Product("product2", "353536", 2, 3.0F);
        Product p33 = new Product("product3", "353537", 2, 2.5F);

        Address a3 = new Address("Bassols", "Barcelona", "Barcelona", "United States");
        Customer c3 = new Customer("Dorian3", a3);

        List<Product> products3 = new List<Product>()
        {
            p31,p32,p33
        };
        Order o3 = new Order(products3, c3);

        //Program
        Console.Clear();
        List<Order> orders = new List<Order>()
        {
            o1, o2, o3
        };

        foreach (Order order in orders)
        {
            order.PackingLabel();
            Console.WriteLine();
            order.ShippingLabel();
            Console.WriteLine();
            Console.WriteLine($"The total price for the order is ${order.TotalCostOrder()}");
            Console.WriteLine();
            Console.WriteLine();            
        }
    }
}