using System;

class Program
{
    static void Main(string[] args)
    {
        int pointsTotal = 0; // current point counter
        List<string> dataList = new List<string>(); // list for data format
        List<string> readList = new List<string>(); // list for read format
        List<string> names = new List<string>(); // list for names of the goals

        string menuChoice = "0";
        while (menuChoice != "6")
        {
            // main menu
            Console.WriteLine(); // blank space
            Console.WriteLine($"You have {pointsTotal} points.");
            Console.WriteLine(); // blank space
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();

            // variables for class creation
            string name;
            string description;
            int points;

            switch (menuChoice)
            {
                // 1. create new goal
                case "1":

                    string goalChoice = "0";

                    while (goalChoice != "1" && goalChoice != "2" && goalChoice != "3")
                    {
                        // choose which type of goal to make
                        Console.WriteLine("The types of Goals are:");
                        Console.WriteLine("  1. Simple Goal");
                        Console.WriteLine("  2. Eternal Goal");
                        Console.WriteLine("  3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        goalChoice = Console.ReadLine();
                    }

                    switch (goalChoice)
                    {

                        // 1. simple goal
                        case "1":
                            
                            // simple goal data acquisition
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            // make data and read formats of goal, add to lists
                            SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                            dataList.Add(simpleGoal.DataFormat());
                            readList.Add(simpleGoal.ReadFormat());
                            names.Add(name);

                            break;

                        // 2. eternal goal
                        case "2":
                            
                            // eternal goal data acquisition
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());

                            // make data and read formats of goal, add to lists
                            EternalGoal eternalGoal = new EternalGoal(name, description, points);
                            dataList.Add(eternalGoal.DataFormat());
                            readList.Add(eternalGoal.ReadFormat());
                            names.Add(name);

                            break;
                        
                        // 3. checklist goal
                        case "3":
                            
                            // checklist goal data acquisition
                            Console.Write("What is the name of your goal? ");
                            name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            points = int.Parse(Console.ReadLine());
                            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                            int numberNeeded = int.Parse(Console.ReadLine());
                            Console.Write("What is the bonus for accomplishing it that many times? ");
                            int completionBonus = int.Parse(Console.ReadLine());

                            // make data and read formats of goal, add to lists
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, numberNeeded, completionBonus);
                            dataList.Add(checklistGoal.DataFormat());
                            readList.Add(checklistGoal.ReadFormat());
                            names.Add(name);

                            break;
                    }
                    
                    break;

                // 2. list goals
                case "2":
                    
                    int goalPosition = 0;
                    foreach (string goal in readList)
                    {
                        goalPosition += 1;
                        Console.WriteLine($"{goalPosition}. {goal}");
                    }

                    break;

                // 3. save goals
                case "3":
                    // write code -----------------
                    break;

                // 4. load goals
                case "4":
                    // write code -----------------
                    break;

                // 5. record event
                case "5":
                    
                    // list the goals
                    int namePosition = 0;
                    Console.WriteLine("The goals are:");
                    foreach(string goalName in names)
                    {
                        namePosition += 1;
                        Console.WriteLine($"{namePosition}. {goalName}");
                    }

                    // ask which goal had an event
                    Console.Write("Which goal did you accomplish? ");
                    int goalDone = int.Parse(Console.ReadLine());

                    // format data of goal done
                    string chosenGoal = dataList.ElementAt(goalDone - 1);
                    string[] data = chosenGoal.Split("|");

                    // goal is a simple goal
                    if (data[0] == "SimpleGoal")
                    {
                        // reconstruct class, mark as complete, replace in the data and read lists
                        SimpleGoal simpleGoal = new SimpleGoal(data[1], data[2], int.Parse(data[3]));
                        int addPoints = simpleGoal.RecordEvent();
                        dataList[goalDone - 1] = simpleGoal.DataFormat();
                        readList[goalDone - 1] = simpleGoal.ReadFormat();

                        Console.WriteLine($"Congratulations! You have earned {addPoints} points!");
                        pointsTotal += addPoints;
                    }

                    // write code for eternal goal and checklist goal
                    // ----------------------------------------------------------------------------------------------------

                    break;

                // 6. quit
                default:
                    break;
            }
        }
    }
}