using System;

public class Activity
{
    //Attributes
    private string _date;
    private int _length; 
    private string _activity;
    //Constructors
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    //Getters and Setters
    public string GetDate()
    {
        return _date;
    }
    public int GetLength()
    {
        return _length;
    }
    public void SetActivity(string activity)
    {
        _activity = activity;
    }
    //Methods
    public virtual float GetDistance()
    {
        return (GetSpeed() / 60) * GetLength();
    }

    public virtual float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
    public virtual float GetPace()
    {
        return 60 / GetSpeed();
    }
    public void Summary()
    {
        Console.WriteLine($"{GetDate()} {_activity} ({GetLength()} min): Distance {float.Round(GetDistance() , 2)} km, Speed: {float.Round(GetSpeed() , 2)} kph, Pace: {float.Round(GetPace() , 2)} min per km");
    }
}