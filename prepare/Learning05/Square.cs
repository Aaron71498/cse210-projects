using System;

class Square : Shape
{
    // attribute
    private double _side;

    // constructor
    public Square(string color, double side) : base(color)
    {
        _side = side;
    }

    // get the area of a square
    public override double GetArea()
    {
        return Math.Pow(_side, 2);
    }
}