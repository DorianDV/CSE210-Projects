using System;

public class Swimming : Activity
{
    //Attributes
    private float _laps;
    //Constructors
    public Swimming(string date, int length, int laps) : base(date, length)
    {
        _laps = laps;
        SetActivity("Swimming");
    }
    //Getters and Setters

    //Methods
    public override float GetDistance()
    {
        return _laps * 50 / 1000;
    }
    public override float GetSpeed()
    {
        return GetDistance() / GetLength() * 60;
    }
}