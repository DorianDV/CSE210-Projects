using System;

public class EternalGoal : Goal
{
    //Attributes

    //Getters and Setters
    
    //Constructors
    
    //Methods
        
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
        return GetGoalPoints();
    }
    public override string Save()
    {
        return $"EternalGoal:{GetName()},{GetDescription()},{GetGoalPoints()}";
    }
    public override void FactoryPattern(string[] attributes)
    {
        SetName(attributes[0]);
        SetDescription(attributes[1]);
        SetGoalPoints(int.Parse(attributes[2]));
    }
    
}