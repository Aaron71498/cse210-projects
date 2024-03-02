using System;

class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // methods
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    // the message for the beginning of each activity
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
    }

    // the message for the end of each activity
    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        Console.WriteLine(); // blank space
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
    }
}