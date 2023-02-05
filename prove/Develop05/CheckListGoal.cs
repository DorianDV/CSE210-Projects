using System;

public class CheckListGoal : Goal
{
    //Attributes
    private int _times;
    private int _bonus;
    private int _counter;

    //Getters and Setters
    
    //Constructors
    
    //Methods
    private void AskTimes()
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _times = int.Parse(Console.ReadLine());
    }
    private void AskBonus()
    {
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonus = int.Parse(Console.ReadLine());
    }
    public override void DefineGoalMessage()
    {
        AskName();
        AskDescription();
        AskGoalPoints();
        AskTimes();
        AskBonus();
    }
    public override string ListingGoal()
    {
        if (GetCompleted())
        {
            return $"[X] {GetName()} ({GetDescription()}) -- Currently completed {_counter}/{_times}";
        }
        else
        {
            return $"[ ] {GetName()} ({GetDescription()}) -- Currently completed {_counter}/{_times}";
        }
        
    }
    public override int RecordEvent()
    {
        _counter++;
        if (_counter < _times)
        {
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints()} points!");
            return GetGoalPoints();
        }
        else if (_counter == _times)
        {
            Console.WriteLine($"Congratulations! You have earned {GetGoalPoints() + _bonus} points!");
            SetCompleted(true);
            return GetGoalPoints() + _bonus;
        }
        else
        {
            Console.WriteLine("This goal is completed.");
            return 0;
        }   
    }
    public override string Save()
    {
        return $"CheckListGoal:{GetName()},{GetDescription()},{GetGoalPoints()},{_bonus},{_times},{_counter}";
    }
    
    public override void FactoryPattern(string[] attributes)
    {
        SetName(attributes[0]);
        SetDescription(attributes[1]);
        SetGoalPoints(int.Parse(attributes[2]));
        _bonus = int.Parse(attributes[3]);
        _times = int.Parse(attributes[4]);
        _counter = int.Parse(attributes[5]);
        if(_counter < _times)
        {
            SetCompleted(false);
        }
        else
        {
            SetCompleted(true);
        }
    }
}