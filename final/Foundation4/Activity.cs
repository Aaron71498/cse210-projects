using System;

public abstract class Activity
{
    // attributes
    private string _date;
    private float _minutes;

    // constructor
    public Activity(string date, float minutes)
    {
        _date = date;
        _minutes = minutes;
    }
}