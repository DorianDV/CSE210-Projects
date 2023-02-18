using System;

public class Cycling : Activity
{
    //Attributes
    private float _speed;
    //Constructors
    public Cycling(string date, int length, int speed) : base(date, length)
    {
        _speed = speed;
        SetActivity("Cycling");
    }
    //Getters and Setters

    //Methods
    public override float GetDistance()
    {
        return (_speed / 60) * GetLength();
    }
    public override float GetPace()
    {
        return 60 / _speed;
    }
}