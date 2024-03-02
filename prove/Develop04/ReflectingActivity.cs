using System;
using System.Runtime.CompilerServices;

class ReflectingActivity : Activity
{
    // attributes
    private string _reflectingName = "Reflection Activity";
    private string _reflectingDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
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

    // methods
    public string GetReflectingName()
    {
        return _reflectingName;
    }

    public string GetReflectingDescription()
    {
        return _reflectingDescription;
    }

    // display randomly selected prompt
    public void DisplayReflectingPrompt()
    {
        Random R = new Random();
        int number = R.Next(0, _reflectingPrompts.Count());
        Console.WriteLine(_reflectingPrompts.ElementAt(number));
    }

    // display randomly selected question
    public void DisplayReflectingQuestion()
    {
        Random R = new Random();
        int number = R.Next(0, _reflectingQuestions.Count());
        Console.WriteLine(_reflectingQuestions.ElementAt(number));
    }
}