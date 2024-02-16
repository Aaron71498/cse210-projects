using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // welcome user to the program
        Console.WriteLine("Welcome to the scripture memorizer.");
        Console.WriteLine(); // blank line

        // get reference info from user
        Console.WriteLine("Please enter the reference info for the scripture.");
        Console.Write("Book: ");
        string book = Console.ReadLine();
        Console.Write("Chapter: ");
        string chapter = Console.ReadLine();
        Console.Write("Start Verse: ");
        string startVerse = Console.ReadLine();
        Console.Write("End Verse (leave blank if scripture is only one verse): ");
        string endVerse = Console.ReadLine();

        // construct Reference class
        Reference reference = new Reference(book, chapter, startVerse);
        reference.SetEndVerse(endVerse);

        // get scripture text from user
        Console.WriteLine("Type the scripture text. Type all of it in one line. Do not include the verse numbers.");
        string text = Console.ReadLine();

        // construct Scripture class
        Scripture scripture = new Scripture(reference.ConstructReference(), text);

        // convert scripture text into a list
        List<string> words = scripture.StringToList();

        // make a list of numbers equal to the number of words in the scripture
        List<int> numbers = new List<int>();
        int x = 0;
        foreach (string word in words)
        {
            numbers.Add(x);
            x += 1;
        }

        // clear the console
        Console.Clear();

        // display the reference and scripture to be memorized, and instructions to continue
        Console.Write(scripture.Reference() + " ");
        foreach (string word in words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine(); // blank space
        Console.WriteLine("Press enter to coninue or type 'quit' to finish:");
        string input = Console.ReadLine();

        // keep the user in a loop if they don't input either of the accepted options
        while (input != "quit" && input != "")
        {
            Console.WriteLine("Press enter to coninue or type 'quit' to finish:");
            input = Console.ReadLine();
        }

        // making variables
        int a;
        int b;
        int c;

        // running the memorization loop
        while (input == "" && numbers.Count() > 0)
        {
            // clear the console
            Console.Clear();

            // replace up to 3 random words in the scripture with dash marks (-)
            if (numbers.Count() > 0) // word 1
            {
                a = Random(); // get random number
                Word word = new Word(words.ElementAt(a)); // find word associated with number, send to Word class
                word.SetVisibility(false); // replace all characters with dash marks
                words[a] = word.ReturnWord(); // replace the word in the list with the dash marks
            }
            if (numbers.Count() > 0) // word 2
            {
                b = Random(); // get random number
                Word word = new Word(words.ElementAt(b)); // find word associated with number, send to Word class
                word.SetVisibility(false); // replace all characters with dash marks
                words[b] = word.ReturnWord(); // replace the word in the list with the dash marks
            }
            if (numbers.Count() > 0) // word 3
            {
                c = Random(); // get random number
                Word word = new Word(words.ElementAt(c)); // find word associated with number, send to Word class
                word.SetVisibility(false); // replace all characters with dash marks
                words[c] = word.ReturnWord(); // replace the word in the list with the dash marks
            }

            // display reference, scripture, and instructions again with new words invisible
            Console.Write(scripture.Reference() + " ");
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine(); // blank space
            Console.WriteLine("Press enter to coninue or type 'quit' to finish:");
            input = Console.ReadLine();

            // keep the user in a loop if they don't input either of the accepted options
            while (input != "quit" && input != "")
            {
                Console.WriteLine("Press enter to coninue or type 'quit' to finish:");
                input = Console.ReadLine();
            }
        }

        // function to get a random number from the numbers list
        // and remove that number from the list to prevent repeats
        int Random()
        {
            Random r = new Random();
            int item = r.Next(0, numbers.Count());
            int number = numbers.ElementAt(item);
            numbers.RemoveAt(item);
            return number;
        }
    }
}