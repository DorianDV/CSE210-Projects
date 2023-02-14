using System;

class Customer
{
    //Attributes
    private string _name;
    private Address _address;

    //Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
    //Getters and Setters
    public string GetName()
    {
        return _name;
    }
    public Address GetAddress()
    {
        return _address;
    }
    //Methods
    public bool UsaOrNot()
    {
        return _address.IsItInUsa();
    }
}