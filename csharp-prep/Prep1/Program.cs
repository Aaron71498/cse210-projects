using System;

class Program
{
    static void Main(string[] args)
    {
        // asking for first and last name
        Console.Write("What is your first name? ");
        string first_name = Console.ReadLine();
        Console.Write("What is your last name? ");
        string last_name = Console.ReadLine();

        // returning the names acquired
        Console.WriteLine("");
        Console.WriteLine($"Your name is {last_name}, {first_name} {last_name}.");
    }
}