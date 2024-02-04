using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // initial variables
        string input = "0";
        string fileName = "Journal.txt";
        
        Console.WriteLine("Welcome to the Journal Program!");

        while (input != "3")
        {
            // display main menu
            Console.WriteLine("Please select a number from 1-3:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. View past journal entries");
            Console.WriteLine("3. Quit");

            // get user choice
            input = Console.ReadLine();
            Console.WriteLine(); // extra space

            // menu options
            switch (input)
            {
                // write a new entry
                case "1":

                    // make new Entry, acquire and display current datetime
                    Entry entry = new Entry();
                    entry._entryDateTime = DateTime.Now.ToString();
                    Console.WriteLine(entry._entryDateTime);

                    // select and display random journal prompt
                    PromptGenerator prompt = new PromptGenerator();
                    string entryPrompt = prompt.Random();
                    entry._entryPrompt = entryPrompt;
                    Console.WriteLine(entry._entryPrompt);

                    // acquire user entry
                    string userEntry = Console.ReadLine();
                    entry._entry = userEntry;

                    Console.WriteLine(); // extra space

                    string save = "0";

                    while (save != "2")
                    {
                        // ask if the user wants to save their entry
                        Console.WriteLine("Would you like to save your entry?");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        save = Console.ReadLine();

                        // saving the user's entry
                        if (save == "1")
                        {
                            using (StreamWriter outputFile = new StreamWriter(fileName, append: true))
                            {
                                outputFile.WriteLine(entry._entryDateTime);
                                outputFile.WriteLine(entry._entryPrompt);
                                outputFile.WriteLine(entry._entry);
                                outputFile.WriteLine(); // extra space
                            }

                            break;
                        }

                        Console.WriteLine(); // extra space

                    }

                    break; // end writing
                
                // view journal entries
                case "2":
                    
                    // read and pring each line of the journal
                    string[] lines = File.ReadAllLines(fileName);
                    foreach(string line in lines)
                    Console.WriteLine(line);
                    
                    break;
                
                // case "3": close journal
                default:
                    break;
            }
        }
    }
}