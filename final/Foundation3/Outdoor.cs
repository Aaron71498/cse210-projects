using System;

class Outdoor : Event
{
    // attribute
    private string _weatherForecast;

    // constructor
    public Outdoor(string eventTitle, string description, string date, string time, Address address, string weatherForecast) : base(eventTitle, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    // method to display full event details
    public void OutdoorFullDetails()
    {
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Description: {GetDescription()}");
        Console.WriteLine($"Date: {GetDate()}");
        Console.WriteLine($"Time: {GetTime()}");
        Console.WriteLine($"Address: {GetAddress()}");
        Console.WriteLine("Type of Event: Lecture");
        Console.WriteLine($"Forecast: {_weatherForecast}");
    }

    // method to display short event description
    public void OutdoorShortDescription()
    {
        Console.WriteLine("Type of Event: Outdoor Gathering");
        Console.WriteLine($"Title: {GetEventTitle()}");
        Console.WriteLine($"Date: {GetDate()}");
    }
}