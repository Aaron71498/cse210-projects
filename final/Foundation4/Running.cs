using System;

class Running : Activity
{
    // attribute
    private float _distance;

    // constructor
    public Running(string date, int minutes, float distance) : base(date, minutes)
    {
        _distance = distance;
    }
}