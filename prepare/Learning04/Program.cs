using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment a = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");

        Console.WriteLine(a.GetSummary());
        Console.WriteLine(a.GetHomeworkList());
    }
}