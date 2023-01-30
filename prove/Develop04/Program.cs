using System;

class Program
{
    static void Main(string[] args)
    {
        int userMenuInput = 0;

        List<string> menu = new List<string>
        {
            "Menu Options",
            "   1. Start Breathing Activity",
            "   2. Start Reflecting Activity",
            "   3. Start Listing Activity",
            "   4. Quit"

        };

        while (userMenuInput != 4)
        {
            Console.Clear();
            foreach (string option in menu)
            {
                Console.WriteLine(option);
            }
            Console.Write("Select a choice from the menu: ");
            userMenuInput = int.Parse(Console.ReadLine());
            Console.Clear();

            //Diferent Activities

            switch (userMenuInput)
            {
                case 1:
                    
                    BreathingActivity activity1 = new BreathingActivity();
                    activity1.RunAtivity();
                    break;

                case 2:
                    
                    ReflectingActivity activity2 = new ReflectingActivity();
                    activity2.RunAtivity();
                    break;

                case 3:
                    
                    ListingActivity activity3 = new ListingActivity();
                    activity3.RunActivity();
                    break;
                    
                case 4:
                    break;
            }
        }
    }
}
