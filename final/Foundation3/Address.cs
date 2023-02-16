using System;

public class Address
{
    //Attributes
    private string _street, _city, _stateOrProvince, _country;
    //Constructors
    public Address()
    {
        _street = "null";
        _city = "null";
        _stateOrProvince = "null";
        _country = "null";
    }
    public Address(string street, string city, string stateOrProvince, string country)
    {
        _street = street;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }
    // Methods
    public string FullAddress()
    {
        string fullAddress = $"{_street}, {_city} - {_stateOrProvince} - {_country}";
        return fullAddress;
    }
    
}