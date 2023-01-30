using System;

public class ListingActivity : Activity
{
    //Attributes
    private List<string> _prompts, _answers;
    //Constructors
    public ListingActivity() : base()
    {
        SetActivityName("Listing");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        _prompts = new List<string>
        {
            "--- Who are people that you appreciate? ---",
            "--- What are personal strengths of yours? ---",
            "--- Who are people that you have helped this week? ---",
            "--- When have you felt the Holy Ghost this month? ---",
            "--- Who are some of your personal heroes? ---"
        };
    }
    //Methods
    public void RunActivity()
    {
        StartMessage();
        DisplayPromp();
        Answers();
        EndingDisplay();
    }
    private void DisplayPromp()
    {
        Console.WriteLine();
        Console.WriteLine("List as many responses you can to the following prompt:");
        
        int randomIndex = new Random().Next(0, _prompts.Count());
        Console.WriteLine(_prompts[randomIndex]);        
    }
    private void Answers()
    {
        CountDownDisplay("You may begin in:", 4);
        Console.WriteLine();

        _answers = new List<String>();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetUserSessionLengthInput());

        DateTime currentTime = DateTime.Now;
        while(currentTime < futureTime)
        {
            Console.Write("> ");
            _answers.Add(Console.ReadLine());
            currentTime = DateTime.Now;
        }
        Console.WriteLine($"You listed {_answers.Count()} items!");
    }

}