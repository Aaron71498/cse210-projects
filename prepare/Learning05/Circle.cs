using System;

class Circle : Shape
{
    // attribute
    private double _radius;

    // constructor
    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

    // get the area of a circle
    public override double GetArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}