using System;
using System.Collections.Generic;

public class Questions
{
    // public string _name = "";
    // public List<Job> _jobs = new List<Job>();
    
    // public void Display()
    // {
    //     Console.WriteLine($"Name: {_name}");
    //     Console.WriteLine("Jobs:");
    //     foreach (Job job in _jobs)
    //     {
    //         job.Display();
    //     }
    //     // _jobs[0].Display();
    //     // _jobs[1].Display();
    //}

    public List<string> _questionList = new List<string>()
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be",
        "What kind of day are you having, and why?",
        "What's your favorite color, place, food, book, song, or movie, and why?",
        "What do you like to do? How does it make you feel?",
        "Where are you happiest? Describe that place.",
        "How would you like your life to be when you're older?"
    };

    public string Display()
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 9);
        Console.WriteLine(_questionList[number]);
        return(_questionList[number]);
    }

}