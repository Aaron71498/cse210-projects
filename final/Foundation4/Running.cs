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

    // override calculation methods
    public override float Distance()
    {
        return _distance;
    }
    public override float Speed()
    {
        return _distance / Minutes() * 60;
    }

    public override string Type()
    {
        return "Running";
    }
}