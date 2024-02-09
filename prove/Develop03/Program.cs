using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference.ConstructReference(), "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all they ways acknowledge him, and he shall direct thy paths.");

        // learn how to generate multiple classes with unique names
    }
}