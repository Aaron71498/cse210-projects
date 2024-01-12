using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for number grade and convert to int
        Console.Write("What is your number grade? ");
        string user_input = Console.ReadLine();
        int number = int.Parse(user_input);

        // prepping variables
        string letter = "";
        string sign = "";
        string message = "";

        // figure out the letter grade from the number grade
        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C";
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // determine if a sign goes with the letter grade
        if (number % 10 >= 7 && number < 97 && number >= 60)
        {
            sign = "+";
        }
        else if (number % 10 < 3 && number >= 60)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // write a message depending on if the user passed or failed
        if (number >= 70)
        {
            message = "You passed. Congratulations!";
        }
        else
        {
            message = "You failed. Try again.";
        }

        // print their letter grade and the appropriate message
        Console.Write($"Your grade is: {letter}{sign}. {message}.");
    }
}