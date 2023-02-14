using System;

class Product
{
    //Attributes
    private string  _name, _id;
    private int _quantity;
    private float _price;
    //Constructors
    public Product(string name, string id, int quantity, float price)
    {
        _name = name;
        _id = id;
        _quantity = quantity;
        _price = price;
    }
    //Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public string GetId()
    {
        return _id;
    }
    //Methods
    public float totalPriceProduct()
    {
        return _quantity * _price;
    }
}