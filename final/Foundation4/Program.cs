using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        DateTime dateTime = DateTime.Now.Date;
        string date = dateTime.ToString("dd MMM yyyy");   
        
        Running r1 = new Running(date, 30, 6);
        Cycling c1 = new Cycling(date, 30, 25);
        Swimming s1 = new Swimming(date, 25, 9);

        List<Activity> activities = new List<Activity>()
        {
            r1, c1, s1
        };

        foreach (Activity activity in activities)
        {
            activity.Summary();
            Console.WriteLine();
        }

    }
}