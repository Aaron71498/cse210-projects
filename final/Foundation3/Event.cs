using System;

class Event
{
    // attributes
    private string _eventTitle;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    // constructor
    public Event(string eventTitle, string description, string date, string time, Address address)
    {
        _eventTitle = eventTitle;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    // methods to get event attributes
    public string GetEventTitle()
    {
        return _eventTitle;
    }
    public string GetDescription()
    {
        return _description;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetTime()
    {
        return _time;
    }
    public string GetAddress()
    {
        return _address.ConstructAddress();
    }

    // method to display standard event details
    public void StandardDetails()
    {
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Time: {_time}");
        Console.WriteLine($"Address: {_address.ConstructAddress()}");
    }
}