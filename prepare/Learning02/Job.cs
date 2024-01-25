using System;

// new Job class
public class Job
{
    // Job info
    public string _company = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    // print job info
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}