using System;

class Program
{
    static void Main(string[] args)
    {
        string input = "0";
        Console.WriteLine("Welcome to the Journal Program!");

        while (input != "5")
        {
            // display main menu
            Console.WriteLine("Please select a number from 1-5:");
            Console.WriteLine("1. Write New Entry");
            Console.WriteLine("2. Display Past Entries");
            Console.WriteLine("3. Load Past Entry");
            Console.WriteLine("4. Save Current Entry");
            Console.WriteLine("5. Quit");

            // get user choice
            input = Console.ReadLine();

            // menu options
            switch (input)
            {
                case "1": // write a new entry
                    
                    // make new Entry, name is current date
                    Entry entry = new Entry();
                    entry._entryName = DateTime.Now.ToShortDateString();

                    // display journal prompt
                    PromptGenerator prompt = new PromptGenerator();
                    string entryPrompt = prompt.Display();
                    entry._entryPrompt = entryPrompt;

                    // acquire user entry
                    string userEntry = Console.ReadLine();
                    entry._entry = userEntry;
                    
                    break;
                
                case "2": // display previous entries
                    Console.WriteLine("Display");
                    break;
                
                case "3": // load a previous entry
                    Console.WriteLine("Load");
                    break;
                
                case "4": // save current entry
                    Console.WriteLine("Save");
                    break;
                
                case "5": // quit the program
                    Console.WriteLine("Quit");
                    break;
                
                default:
                    break;
            }
        }
    }
}