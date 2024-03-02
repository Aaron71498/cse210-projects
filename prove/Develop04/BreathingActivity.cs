using System;

class BreathingActivity : Activity
{
    // attributes
    private string _breathingName = "Breathing Activity";
    private string _breathingDescription = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";

    // constructor
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    // methods
    public string GetBreathingName()
    {
        return _breathingName;
    }

    public string GetBreathingDescription()
    {
        return _breathingDescription;
    }
}