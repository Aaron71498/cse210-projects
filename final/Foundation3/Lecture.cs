using System;

class Lecture : Event
{
    // attributes
    private string _speaker;
    private int _capacity;

    // constructor
    public Lecture(string eventTitle, string description, string date, string time, Address address, string speaker, int capacity) : base(eventTitle, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    // method to display full event details
    public void LectureFullDetails()
    {
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine("Type of Event: Lecture");
        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    // method to display short event description
    public void LectureShortDescription()
    {
        Console.WriteLine("Type of Event: Lecture");
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}