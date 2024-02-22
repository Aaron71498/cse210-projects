using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Assignment sam = new Assignment("Samuel Bennett", "Multiplication");
        MathAssignment rob = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        WritingAssignment mary = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(sam.GetSummary());
        Console.WriteLine(); // blank line
        Console.WriteLine(rob.GetSummary());
        Console.WriteLine(rob.GetHomeworkList());
        Console.WriteLine(); // blank line
        Console.WriteLine(mary.GetSummary());
        Console.WriteLine(mary.GetWritingInformation());
    }
}