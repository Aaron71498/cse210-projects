using System;
using System.Runtime.CompilerServices;

class ReflectingActivity : Activity
{
    // attributes
    private List<string> _reflectingPrompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _reflectingQuestions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    // constructor
    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
    }

    // display randomly selected prompt
    public void DisplayReflectingPrompt()
    {
        Random R = new Random();
        int number = R.Next(0, _reflectingPrompts.Count());
        Console.WriteLine($"--- {_reflectingPrompts.ElementAt(number)} ---");
    }

    // display randomly selected question
    public void DisplayReflectingQuestion()
    {
        Random R = new Random();
        int number = R.Next(0, _reflectingQuestions.Count());
        Console.Write($"> {_reflectingQuestions.ElementAt(number)} ");
    }

    // run the reflecting activity
    public void RunReflectingActivity()
    {
        // get duration
        int duration = GetDuration();

        // activity instructions
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine(); // blank line
        DisplayReflectingPrompt();
        Console.WriteLine(); // blank line
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine(); // wait for user to press enter
        Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");

        Console.Write("You may begin in: ");
        CountdownPause(5);
        Console.Clear(); // clear console

        // run activity
        while (duration > 0)
        {
            DisplayReflectingQuestion();
            SpinnerPause(5);
            Console.WriteLine(); // next line
            duration -=- 10;
        }
    }
}