using System;
using System.Collections.ObjectModel;

class Program
{
    static void Main(string[] args)
    {
        // new list to hold shapes
        List<Shape> shapes = new List<Shape>();

        // new shapes
        Square square = new Square("red", 5);
        Rectangle rectangle = new Rectangle("yellow", 6, 7);
        Circle circle = new Circle("green", 8);

        // add shapes to list
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        // iterate through the list of shapes
        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetColor()} shape has an area of {shape.GetArea()}");
        }
    }
}