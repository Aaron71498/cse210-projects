using System;

public abstract class Shape
{
    // attribute
    private string _color;

    // constructor
    public Shape(string color)
    {
        _color = color;
    }

    // methods
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // get the area of a shape
    public abstract double GetArea();
}