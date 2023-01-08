using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number;
        do
        {
            Console.Write("Enter number: ");
            string userInput = Console.ReadLine();
            number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);
        
        int sumNumber = 0;
        foreach (int i in numbers)
        {
            sumNumber += i;
        }
        Console.WriteLine($"The sum is: {sumNumber}");

        float average = (float)sumNumber / (float)numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine("The largest number is: " + numbers.Max());


    }
}