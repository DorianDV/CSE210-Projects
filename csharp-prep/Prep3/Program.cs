using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");

        
        int guessNumber;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 100);
        
        Console.WriteLine("Welcome to the game!");
    
                
        do
        {
            Console.Write("What is your guess? ");
            string guess = Console.ReadLine();
            guessNumber = int.Parse(guess);

            if (number == guessNumber)
            {
                Console.WriteLine("You guessed it!");
            }
            else if (number > guessNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Lower");
            }
        } while (guessNumber != number);


    }
}