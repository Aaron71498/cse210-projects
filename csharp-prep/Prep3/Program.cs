using System;

class Program
{
    static void Main(string[] args)
    {   
        // set up variables
        int guess = 0;
        int attempts = 0;
        string play_again = "yes";

        // set up game to be replayable
        while (play_again == "yes")
        {
            // Get a random number from the computer
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1,21);

            // while loop that runs the game
            while (guess != number)
            {   
                // obtain guess from user
                Console.WriteLine("What is your guess?");
                string response2 = Console.ReadLine();
                guess = int.Parse(response2);


                // check if guess is higher, lower, or correct
                
                // correct guess, ask if they want to play again
                if (guess == number)
                {
                    Console.WriteLine("You guessed it!");
                    attempts ++;
                    Console.WriteLine($"It took you {attempts} tries.");
                    Console.Write("Would you like to play again? ");
                    play_again = Console.ReadLine();
                }
                // low guess
                else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    attempts ++;
                }
                // high guess
                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    attempts ++;
                }
            }
        }
    }
}