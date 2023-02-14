using System;
using System.Collections.Generic;

class Order
{
    //Attributes
    private List<Product> _products = new List<Product>();
    private Customer _customer;

    //Constructors
    public Order (List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }
    //Getters and Setters

    //Methods
    public float TotalCostOrder()
    {
        float totalCostOrder = 0.0F;
        foreach (Product product in _products)
        {
            totalCostOrder += product.totalPriceProduct();
        }
        if (_customer.UsaOrNot())
        {
            totalCostOrder += 5;
        }
        else
        {
            totalCostOrder += 35;
        }
        
        return totalCostOrder;
    }
    public void PackingLabel()
    {
        int counter = 1;
        foreach (Product product in _products)
        {
            Console.WriteLine($"{counter}. {product.GetName()} - {product.GetId()}");
            counter++;
        }
        
    }
    public void ShippingLabel()
    {
        Console.WriteLine($"{_customer.GetName()}\n{_customer.GetAddress().FullAddress()}");
    }
}