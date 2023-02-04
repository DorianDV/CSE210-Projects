using System;

public class Shape
{
    //Attributes
    private string _color;

    //Getters and Setters
    public string GetColor()
    {
        return _color;
    } 

    public void SetColor(string color)
    {
        _color = color;
    }
    //Constructors
    public Shape(string color)
    {
        _color = color;
    }
    //Methods
    public virtual double GetArea()
    {
        return -1;
    }
    
}