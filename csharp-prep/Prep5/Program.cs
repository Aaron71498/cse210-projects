using System;

class Program
{
    static void Main(string[] args)
    {
        // function to welcome the user
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        // function to get the user's name
        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        // function to get a number from the user
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        // function to square the user's number
        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        // function to print results
        static void DisplayResult(string name, int squareNumber)
        {
            Console.WriteLine($"{name}, the square of your  number is {squareNumber}.");
        }

        // use the functions
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squareNumber = SquareNumber(number);
        DisplayResult(name, squareNumber);

    }
}