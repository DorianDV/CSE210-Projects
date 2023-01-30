using System;
using System.Diagnostics; 

public class Activity
{
    //Attributes
    private string _activityName, _description;
    private int _spinnerCounter, _userSessionLengthInput;
    
    //Constructors
    public Activity()
    {
        _spinnerCounter = 0;
        _userSessionLengthInput = 0;
    }

    //Getters and Setters
    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetUserSessionLengthInput()
    {
        return _userSessionLengthInput;
    }

    //Methods
    private void WelcomeDisplay(){
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
    }

    private void DescriptionDisplay()
    {
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    private void PromptDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _userSessionLengthInput = int.Parse(Console.ReadLine());
    }  
    public void StartMessage()
    {
        WelcomeDisplay();
        DescriptionDisplay();
        PromptDuration();
        GetReady();
        
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        DisplaySpinner(5);
    }
    public void EndingDisplay()
    {
        Console.WriteLine();
        Console.WriteLine("Well Done!!");
        DisplaySpinner(3);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_userSessionLengthInput} seconds of {_activityName} Activity.");
        DisplaySpinner(10);
    }
    public void DisplaySpinner(int numSecondsToRun)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        
        while (stopwatch.ElapsedMilliseconds / 1000 < numSecondsToRun)
        {
            _spinnerCounter++;
            switch (_spinnerCounter % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            
            Console.SetCursorPosition(Console.CursorLeft -1, Console.CursorTop);
            Thread.Sleep(200);
        }
        Console.Write(" ");
    }
    public void CountDownDisplay(string sentense, int numSecondsToRun)
    {
        for (int i = numSecondsToRun; i >= 1; i--)
        {
            Console.Write($"{sentense} {i}");
            Console.SetCursorPosition(0, Console.CursorTop);
            Thread.Sleep(1000);            
        }
        Console.SetCursorPosition(0, Console.CursorTop);
        Console.Write($"{sentense}    ");
        
    }
}