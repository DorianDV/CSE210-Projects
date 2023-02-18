using System;

public class Running : Activity
{
    //Attributes
    private float _distance;
    //Constructors
    public Running(string date, int length, float distance) : base (date, length)
    {
        _distance = distance;
        SetActivity("Running");
    }

    //Getters and Setters

    //Methods
    public override float GetSpeed()
    {
        return _distance / GetLength()* 60;
    }
    
}