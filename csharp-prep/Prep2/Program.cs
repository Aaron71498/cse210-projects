using System;

class Program
{
    static void Main(string[] args)
    {
        // ask for number grade and convert to int
        Console.Write("What is your number grade? ");
        string user_input = Console.ReadLine();
        int number_grade = int.Parse(user_input);

        string letter = "";

        // figure out the letter grade from the number grade
        if (number_grade >= 90)
        {
            letter = "A";
        }
        else if (number_grade >= 80)
        {
            letter = "B";
        }
        else if (number_grade >= 70)
        {
            letter = "C";
        }
        else if (number_grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string message = "";

        // write a message depending on if the user passed or failed
        if (number_grade >= 70)
        {
            message = "You passed. Congratulations!";
        }
        else
        {
            message = "You failed. Try again.";
        }

        // print their letter grade and the appropriate message
        Console.Write($"Your grade is: {letter}. {message}.");
    }
}