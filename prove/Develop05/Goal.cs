using System;
using System.IO; 

public class Goal
{
    //Attributes
    private string _name;
    private string _description;
    private int _goalPoints;
    // private int _realPoints;
    private bool _completed = false;

    //Getters and Setters
     public string GetName()
    {
        return _name;
    } 
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetDescription()
    {
        return _description;
    } 
    public void SetDescription(string description)
    {
        _description = description;
    }
    public int GetGoalPoints()
    {
        return _goalPoints;
    } 
    public void SetGoalPoints(int points)
    {
        _goalPoints = points;
    }
    // public int GetRealPoints()
    // {
    //     return _realPoints;
    // } 
    // public void SetRealPoints(int realPoints)
    // {
    //     _realPoints = realPoints;
    // }
    public bool GetCompleted()
    {
        return _completed;
    }
    public void SetCompleted(bool completed)
    {
        _completed = completed;
    }
    //Constructors
    
    //Methods
    protected void AskName()
    {
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());
    }
    protected void AskDescription()
    {
        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());
    }
    protected void AskGoalPoints()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        SetGoalPoints(int.Parse(Console.ReadLine()));
    }
    public virtual void DefineGoalMessage()
    {
        AskName();
        AskDescription();
        AskGoalPoints();
    }
    public virtual string ListingGoal()
    {
        if (_completed)
        {
            return $"[X] {_name} ({_description})";
        }
        else
        {
            return $"[ ] {_name} ({_description})";
        }
        
    }
    public virtual int RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_goalPoints} points!");
        return _goalPoints;
    }
    public virtual string Save()
    {
        return $"SimpleGoal:{_name},{_description},{_goalPoints},{_completed}";
    }
   public virtual void FactoryPattern(string[] attributes)
    {
        _name = attributes[0];
        _description = attributes[1];
        _goalPoints = int.Parse(attributes[2]);
        _completed = bool.Parse(attributes[3]);
    }
}