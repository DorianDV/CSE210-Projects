using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    Entry entry = new Entry();

    public void Add()
    {
        Questions questions = new Questions();
        //Get Date
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        //Pass question, answer and date to List in Class Entry.
        entry._questions.Add(questions.Display());
        entry._answers.Add(Console.ReadLine());
        entry._dates.Add(dateText);  
    }

    public void Save(string _filename)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            for (int i = 0; i < entry._answers.Count; i++) 
            {
                outputFile.WriteLine($"{entry._dates[i]}|{entry._questions[i]}|{entry._answers[i]}"); 
            }
        } 

    }

    public void Display()
    {
        entry.Display();
    }

    public void Load(string _filename)
    {
        string[] lines = System.IO.File.ReadAllLines(_filename);

        entry._answers.Clear();
        entry._questions.Clear();
        entry._dates.Clear();

        foreach (string line in lines)
        {
            string[] parts = line.Split("|");
            entry._dates.Add(parts[0]);
            entry._questions.Add(parts[1]);
            entry._answers.Add(parts[2]);
        }

    }
}