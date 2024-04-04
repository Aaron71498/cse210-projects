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

    // get minutes
    public float Minutes()
    {
        return _minutes;
    }

    // calculate distance
    public virtual float Distance()
    {
        return 0;
    }

    // calculate speed
    public virtual float Speed()
    {
        return 0;
    }

    // calculate pace
    public float Pace()
    {
        return 60 / Speed();
    }

    // type of workout
    public virtual string Type()
    {
        return "";
    }

    // create summary of workout
    public string Summary()
    {
        return $"{_date} {Type()} ({_minutes} min)- Distance: {Distance()} km, Speed: {Speed()} kph, Pace: {Pace()} min per km";
    }
}