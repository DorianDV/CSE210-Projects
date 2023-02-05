using System;
using System.Collections.Generic;
using System.IO; 

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;
        int userGoalMenuInput = 0;
        int points = 0;
        int counter1 = 0;

        List<string> menu = new List<string>
        {
            "Menu Options",
            "   1. Create New Goal",
            "   2. List Goals",
            "   3. Save Goals",
            "   4. Load Goals",
            "   5. Record Event",
            "   6. Quit"

        };
        List<string> goalMenu = new List<string>
        {
            "The types of Goals are:",
            "   1. Simple Goal",
            "   2. Eternal Goal",
            "   3. CheckList Goal"
        };

        List<Goal> goals = new List<Goal>();

        while (userMenuInput != 6)
        {
            Console.Clear();
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine();

            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            

            //Diferent Activities

            switch (userMenuInput)
            {
                case 1:
                //Create New Goal 
                    foreach (string option in goalMenu)
                    {
                        Console.WriteLine(option);
                    }
                    Console.Write("Which type of goal would you like to create? ");
                    userGoalMenuInput = int.Parse(Console.ReadLine());
                    switch (userGoalMenuInput)
                    {
                        case 1:
                            goals.Add(new Goal());
                            goals[counter1].DefineGoalMessage();
                            break;
                        case 2:
                            goals.Add(new EternalGoal());
                            goals[counter1].DefineGoalMessage();
                            
                            break;
                        case 3:
                            goals.Add(new CheckListGoal());
                            goals[counter1].DefineGoalMessage();
                            break;
                    }
                    counter1++;
                    break;

                case 2:
                // List Goals
                    Console.Clear();
                    string listed;
                    int counter2 = 1;
                    Console.WriteLine("The goals are:");
                    foreach (Goal goal in goals)
                    {
                        listed = goal.ListingGoal();
                        Console.WriteLine($"{counter2}. {listed}");
                        counter2++;
                    }
                    Console.Write("Press Enter to continue.");
                    Console.ReadLine();
                    break;

                case 3:
                // Save Goals
                    Console.Write("What is the filename for the goal file? ");
                    
                    string fileName = Console.ReadLine();

                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {
                        outputFile.WriteLine(points);
                        foreach (Goal goal in goals)
                        {
                            outputFile.WriteLine(goal.Save());
                        }
                    }                    
                    break;
                    
                case 4:
                // Load Goals
                    Console.Write("What is the filename for the goal file? ");
                    
                    fileName = Console.ReadLine();
                    
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    int counter3 = 0;

                    points = int.Parse(lines[0]);

                    foreach (string line in lines)
                    {
                        if (line != lines[0])
                        {
                            string[] parts = line.Split(":");
                        
                            string goalType = parts[0];
                            string goalAttributes = parts[1];
                             
                            switch (goalType)
                            {
                                case "SimpleGoal":
                                    
                                    string[] attributes = goalAttributes.Split(",");
                                    goals.Add(new Goal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;

                                case "EternalGoal":
                                    
                                    attributes = goalAttributes.Split(",");
                                    goals.Add(new EternalGoal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;
                                case "CheckListGoal":
                                    
                                    attributes = goalAttributes.Split(",");
                                    goals.Add(new CheckListGoal());
                                    goals[counter3].FactoryPattern(attributes);
                                    counter3++;
                                    break;    
                            }
                            
                        }
                        
                    }  
                    counter1 += counter3;
                    break;
                
                case 5:
                // Record Event
                    int i = 1;
                    int j = 0;
                    int numberOfGoals = goals.Count();
                    bool completed;

                    foreach (Goal goal in goals)
                    {
                        completed = goal.GetCompleted();
                        if (completed)
                        {
                            j++;
                        }
                    }
                    if (j == numberOfGoals)
                    {
                        Console.WriteLine("There aren't Goals to complete. Press Enter to come back to menu.");
                        Console.ReadLine();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("The goals are:"); 
                        foreach (Goal goal in goals)
                        {
                            completed = goal.GetCompleted();
                            if (!completed)
                            {
                                Console.WriteLine($"{i}. {goal.GetName()}");   
                            }
                            i++;
                        }
                        Console.Write("Which goal do you accomplish? ");
                        int inputAnswer = int.Parse(Console.ReadLine()); 
                        points += goals[inputAnswer -1].RecordEvent();
                        Console.WriteLine($"You now have {points} points\n");
                        Console.Write("Press Enter to continue.");
                        Console.ReadLine();
                    }
                    break;             
                
                case 6:
                //  Quit
                    break;
            }
            
        }
    }
    
}