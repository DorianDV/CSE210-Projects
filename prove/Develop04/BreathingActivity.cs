using System;

public class BreathingActivity : Activity
{
    //Attributes

    //Constructors
    public BreathingActivity() : base()
    {
        SetActivityName("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
    }

    //Methods
    public void RunAtivity()
    {
        StartMessage();
        if (GetUserSessionLengthInput() < 20)
        {
            Console.WriteLine();
            Console.Write("You need at least 20 seconds to do this activity. Press Enter to return to the main menu. ");
            Console.ReadLine();
        }
        else
        {
            Sequence();
            EndingDisplay();
        }        
        
         
    }

    private void Sequence()
    {
        

        int userInput = GetUserSessionLengthInput();
        int availableTime = userInput/19;
             
        if (availableTime > 0)
        {

            for (int i = 0; i < availableTime; i++)
            {
                Console.WriteLine();
                CountDownDisplay("Breathe in...", 4);
                Console.WriteLine();
                CountDownDisplay("Hold your breath...", 7);
                Console.WriteLine();
                CountDownDisplay("Breathe out...", 8);
                Console.WriteLine();
            }
            if (availableTime * 19 < userInput)
            {
                int x = userInput - (19 * availableTime);
                Console.WriteLine();
                CountDownDisplay("Relax...", x);
                Console.WriteLine();
            } 
        }        
    }
}