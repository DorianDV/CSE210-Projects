using System;

public class Receptions : Event
{
    //Attributes
    private string _email;
    
    //Constructors
   public Receptions(string tittle, string description, string date, string time, string type, Address address, string email) : base(tittle, description, date, time, type, address)
    {
        _email = email;
    }   
    
    //Getters and Setters

    //Methods
    public void DisplayFull()
    {
        Console.WriteLine($"{GetTittle()}\n{GetDescription()}\n{GetDate()} {GetTime()}\n{GetAddress().FullAddress()}");
        Console.WriteLine($"Make your reservation writing to the following email : {_email}");
    }   
}