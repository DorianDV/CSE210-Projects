using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");

        //Write a program that determines the grae letter for a course 

        Console.Write("What is your grade percentage? ");
        string userInput = Console.ReadLine();
        int number = int.Parse(userInput);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number < 90 && number >= 80)
        {
            letter = "B";
        }
        else if (number < 80 && number >= 70)
        {
            letter = "C";
        }
        else if (number < 70 && number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter is {letter}.");

        if (number >= 70)
        {
            Console.WriteLine("Congratulation.");
        }
        else 
        {
            Console.WriteLine("The next time will be better.");
        }
    }
}