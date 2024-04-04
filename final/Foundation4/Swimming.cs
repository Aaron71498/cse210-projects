using System;

class Swimming : Activity
{
    // attribute
    private float _laps;

    // constructor
    public Swimming(string date, float minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    // override calculation methods
    public override float Distance()
    {
        return _laps * 50 / 1000;
    }
    public override float Speed()
    {
        return Distance() / Minutes() * 60;
    }

    public override string Type()
    {
        return "Swimming";
    }
}