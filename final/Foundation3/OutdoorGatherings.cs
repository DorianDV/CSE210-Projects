using System;

public class OutdoorGatherings : Event
{
    //Attributes
    private string _weather;
    //Constructors
    public OutdoorGatherings(string tittle, string description, string date, string time, string type, Address address, string weather) : base(tittle, description, date, time, type, address)
    {
        _weather = weather;
    }   
    //Getters and Setters

    //Methods
    public void DisplayFull()
    {
        Console.WriteLine($"{GetTittle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress().FullAddress()}");
        Console.WriteLine($"The Weather is {_weather}");
    }    
}