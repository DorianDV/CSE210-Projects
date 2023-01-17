using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop02 World!");

        string option = "";

        List<string> choices = new List<string>()
        {
            "1. Write",
            "2. Display",
            "3. Load",
            "4. Save",
            "5. Quit"
        };
        
        Journal journal = new Journal();
        

        while (option != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            foreach (string choice in choices)
            {
                Console.WriteLine(choice);
            }
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {    
                //Adding an entry
                journal.Add();
            }
            else if (option == "2")
            {
                //Display all entries
                journal.Display();
            }
            else if (option == "3")
            {
                //load from File
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Load(filename);
            }
            else if (option == "4")
            {
                //Save to File
                Console.WriteLine("What is the filename? ");
                string filename = Console.ReadLine();
                journal.Save(filename);
            }
            else if (option == "5")
            {
                Console.WriteLine("Good bye.");
            }
            else
            {
                Console.WriteLine($"The choice {option} does not exist.");
            }
        }
    }
}