using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        
        Job job1 = new Job();
        job1._jobTitle = "Application Engineer";
        job1._company = "Elion";
        job1._startYear = 2022;
        job1._endYear = 2028;
        //string companyName1 = job1._company;
        //Console.WriteLine(companyName1);
        //job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Becario";
        job2._company = "Applus";
        job2._startYear = 2021;
        job2._endYear = 2022;
        //string companyName2 = job2._company;
        //Console.WriteLine(companyName2);
        //job2.Display();

        Resume resume = new Resume();
        resume._name = "Dorian Delugo";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        //string prueba1 = resume._jobs[0]._jobTitle;
        //string prueba2 = resume._jobs[1]._jobTitle;
        //Console.WriteLine(prueba1);
        //Console.WriteLine(prueba2);
        resume.Display();
    }
}