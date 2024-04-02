using System;

class Reception : Event
{
    // attribute
    private string _rsvpEmail;

    // constructor
    public Reception(string eventTitle, string description, string date, string time, Address address, string rsvpEmail) : base(eventTitle, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    // method to display full event details
    public void ReceptionFullDetails()
    {
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine("Type of Event: Reception");
        Console.WriteLine($"RSVP at: {_rsvpEmail}");
    }

    // method to display short event description
    public void ReceptionShortDescription()
    {
        Console.WriteLine("Type of Event: Reception");
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}