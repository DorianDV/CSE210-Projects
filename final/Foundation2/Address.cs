using System;

class Address
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
    //Getters and Setters

    //Methods
    public bool IsItInUsa()
    {
        if (_country == "USA" || _country == "United States")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string FullAddress()
    {
        string fullAddress = $"{_street}, {_city}\n{_stateOrProvince} - {_country}";
        return fullAddress;
    }
}