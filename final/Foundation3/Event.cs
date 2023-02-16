using System;

public class Event
{
    //Attributes
    private string _tittle, _description, _date, _time, _type;
    private Address _address;
    //Constructors
    public Event(string tittle, string description, string date, string time, string type, Address address)
    {
        _tittle = tittle;
        _description = description;
        _date = date;
        _time = time;
        _type = type;
        _address = address;
    }
    //Getters and Setters
    public string GetTittle()
    {
        return _tittle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string Get_Type()
    {
        return _type;
    }
    public Address GetAddress()
    {
        return _address;
    }
    //Methods
    public void DisplayStandard()
    {
        Console.WriteLine($"{_tittle}\n{_description}\n{_date} {_time}\n{_address.FullAddress()}");
    }
    public void DisplayShort()
    {
        Console.WriteLine($"{_type}\n{_tittle}\n{_date}");
    }    
}