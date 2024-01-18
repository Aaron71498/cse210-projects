using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        // create a new list for numbers
        List<int> numbers = new List<int>();

        // instruct user to enter numbers
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;

        // continue receiving numbers until the user enters 0
        while (number != 0)
        {
            // user inputs a number
            Console.Write("Enter number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            // add number to the numbers list if not 0
            if (number != 0)
            {
                numbers.Add(number);
            }
        }

        // calculate and print the sum of the numbers
        double sum = 0;
        foreach (int i in numbers)
        {
            sum += i;
        }
        Console.WriteLine($"The sum is: {sum}");

        // calculate and print the average of the numbers
        double average = sum / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // find and print the largest number
        int largest = 0;
        foreach (int i in numbers)
        {
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The largest number is: {largest}");

        // find and print the smallest positive number
        int smallest = 999;
        foreach (int i in numbers)
        {
            if (i < smallest && i > 0)
            {
                smallest = i;
            }
        }
        Console.WriteLine($"The smallest positive number is: {smallest}");

        // sort and print the numbers list from least to greatest
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        foreach (int i in numbers)
        {
            Console.WriteLine(i);
        }
    }
}