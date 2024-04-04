using System;

class Bicycles : Activity
{
    //attribute
    private float _speed;

    // constructor
    public Bicycles(string date, float minutes, float speed) : base(date, minutes)
    {
        _speed = speed;
    }

    // override calculation methods
    public override float Distance()
    {
        return Minutes() * _speed / 60;
    }
    public override float Speed()
    {
        return _speed;
    }

    public override string Type()
    {
        return "Stationary Bicycles";
    }
}