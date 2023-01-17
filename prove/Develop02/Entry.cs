using System;
using System.Collections.Generic;

public class Entry
{
    public List<string> _questions = new List<string>();
    public List<string> _answers = new List<string>();
    public List<string> _dates = new List<string>();

    public void Display()
    {
        for (int i = 0; i < _answers.Count; i++) 
        {
           Console.WriteLine($"Date: {_dates[i]} - Prompt: {_questions[i]}\n{_answers[i]}");
           Console.WriteLine(); 
        }
    }
}