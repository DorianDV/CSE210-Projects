using System;

public class Lectures : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;
    //Constructors
   public Lectures(string tittle, string description, string date, string time, string type, Address address, string speaker, int capacity) : base(tittle, description, date, time, type, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }   
    
    //Getters and Setters

    //Methods
    public void DisplayFull()
    {
        Console.WriteLine($"{GetTittle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress().FullAddress()}");
        Console.WriteLine($"The Speaker is {_speaker} and the capacity is {_capacity} persons.");
    }   
}