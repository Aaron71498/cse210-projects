using System;

class Program
{
    static void Main(string[] args)
    {
        // number of times each activity was completed this time
        int breathingCompleted = 0;
        int reflectingCompleted = 0;
        int listingCompleted = 0;

        // program runs while "4. quit" is not selected
        string input = "0";
        while (input != "4")
        {
            // main menu
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");
            input = Console.ReadLine(); // user choice
            
            Console.Clear(); // clear console

            switch (input)
            {
                // 1. breathing activity
                case "1":
                    BreathingActivity ba = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");
                    Console.Clear(); // clear console
                    ba.StartMessage(); // display start message
                    ba.RunBreathingActivity(); // run breathing activity
                    ba.EndMessage(); // display end message
                    Console.Clear(); // clear console
                    breathingCompleted += 1;
                    break;

                // 2. reflecting activity
                case "2":
                    ReflectingActivity ra = new ReflectingActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                    Console.Clear(); // clear console
                    ra.StartMessage(); // display start message
                    ra.RunReflectingActivity(); // run reflecting activity
                    ra.EndMessage(); // display end message
                    Console.Clear(); // clear console
                    reflectingCompleted += 1;
                    break;

                // 3. listing activity
                case "3":
                    ListingActivity la = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                    Console.Clear(); // clear console
                    la.StartMessage(); // display start message
                    la.RunListingActivity(); // run listing activity
                    la.EndMessage(); // display end message
                    Console.Clear(); // clear console
                    listingCompleted += 1;
                    break;

                // 4. quit
                default:
                    Console.WriteLine("Here's how many times you completed each activity today:");
                    Console.WriteLine($"Breathing Activity: {breathingCompleted} time(s)");
                    Console.WriteLine($"Reflecting Activity: {reflectingCompleted} time(s)");
                    Console.WriteLine($"Listing Activity: {listingCompleted} time(s)");
                    Console.Write("Hit enter to quit.");
                    Console.ReadLine();
                    Console.Clear();
                    break;
            }
        }
    }
}