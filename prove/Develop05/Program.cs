using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int pointsTotal = 0; // current point counter
        List<string> dataList = new List<string>(); // list for data format
        List<string> readList = new List<string>(); // list for read format
        List<string> names = new List<string>(); // list for names of the goals

        string menuChoice = "0";
        while (menuChoice != "7")
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
            Console.WriteLine("  6. Erase Goal");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            menuChoice = Console.ReadLine();
            Console.WriteLine(); // blank line

            // variables for class creation
            string name;
            string description;
            int points;

            switch (menuChoice)
            {
                // ------------------
                // 1. create new goal
                // ------------------
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
                        Console.WriteLine(); // blank line
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
                            ChecklistGoal checklistGoal = new ChecklistGoal(name, description, points, completionBonus, numberNeeded);
                            dataList.Add(checklistGoal.DataFormat());
                            readList.Add(checklistGoal.ReadFormat());
                            names.Add(name);

                            break;
                    }
                    
                    break;

                // -------------
                // 2. list goals
                // -------------
                case "2":
                    
                    int goalPosition = 0;
                    foreach (string goal in readList)
                    {
                        goalPosition += 1;
                        Console.WriteLine($"{goalPosition}. {goal}");
                    }

                    break;

                // -------------
                // 3. save goals
                // -------------
                case "3":
                    
                    // open the text file to write to it
                    using (StreamWriter outputFile = new StreamWriter("goals.txt"))
                    {
                        // add the total points to the text file
                        outputFile.WriteLine(pointsTotal);

                        // add the data format of each goal to the text file
                        foreach (string goalData in dataList)
                        {
                            outputFile.WriteLine(goalData);
                        }
                    }

                    break;

                // -------------
                // 4. load goals
                // -------------
                case "4":
                    
                    // read only the first line from text file to get points
                    pointsTotal = int.Parse(File.ReadLines("goals.txt").First());
                    
                    // read each line from text file
                    string[] lines = System.IO.File.ReadAllLines("goals.txt");
                    foreach (string line in lines)
                    {
                        // split each line into their individual parts
                        string[] parts = line.Split("|");
                        
                        // use classes to add each line to the data, read, and names lists
                        
                        // simple goals
                        if (parts[0] == "SimpleGoal")
                        {
                            // construct class
                            SimpleGoal simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));

                            // check completion
                            if (parts[4] == "True")
                            {
                                simpleGoal.IsComplete();
                            }

                            // add data to lists
                            dataList.Add(simpleGoal.DataFormat());
                            readList.Add(simpleGoal.ReadFormat());
                            names.Add(parts[1]);
                        }

                        // eternal goals
                        else if (parts [0] == "EternalGoal")
                        {
                            // construct class
                            EternalGoal eternalGoal = new EternalGoal(parts[1], parts[2], int.Parse(parts[3]));

                            // add data to lists
                            dataList.Add(eternalGoal.DataFormat());
                            readList.Add(eternalGoal.ReadFormat());
                            names.Add(parts[1]);
                        }

                        // checklist goals
                        else if (parts[0] == "ChecklistGoal")
                        {
                            // construct class
                            ChecklistGoal checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]));

                            // check completion
                            if (parts[7] == "True")
                            {
                                checklistGoal.IsComplete();
                            }

                            // add data to lists
                            dataList.Add(checklistGoal.DataFormat());
                            readList.Add(checklistGoal.ReadFormat());
                            names.Add(parts[1]);
                        }
                    }

                    break;

                // ---------------
                // 5. record event
                // ---------------
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

                    // make sure the input number is within the range of the list of goals
                    if (goalDone >= 1 && goalDone <= names.Count)
                    {
                        // split data of goal done into individual strings
                        string chosenGoal = dataList.ElementAt(goalDone - 1);
                        string[] data = chosenGoal.Split("|");

                        // now work with the goals depending on what they are
                        int addPoints = 0;
                        // goal is a simple goal
                        if (data[0] == "SimpleGoal")
                        {
                            // construct class, get points and mark as complete, replace in the data and read lists
                            SimpleGoal simpleGoal = new SimpleGoal(data[1], data[2], int.Parse(data[3]));
                            addPoints = simpleGoal.RecordEvent();
                            dataList[goalDone - 1] = simpleGoal.DataFormat();
                            readList[goalDone - 1] = simpleGoal.ReadFormat();
                        }

                        // goal is an eternal goal
                        else if (data[0] == "EternalGoal")
                        {
                            // construct class, get points, replace in the data and read lists
                            EternalGoal eternalGoal = new EternalGoal(data[1], data[2], int.Parse(data[3]));
                            addPoints  = eternalGoal.RecordEvent();
                            dataList[goalDone - 1] = eternalGoal.DataFormat();
                            readList[goalDone - 1] = eternalGoal.ReadFormat();
                        }

                        // goal is a checklist goal
                        else if (data[0] == "ChecklistGoal")
                        {
                            // construct class, get points, replace in the data and read lists
                            ChecklistGoal checklistGoal = new ChecklistGoal(data[1], data[2], int.Parse(data[3]), int.Parse(data[4]), int.Parse(data[5]), int.Parse(data[6]));
                            addPoints = checklistGoal.RecordEvent();
                            dataList[goalDone - 1] = checklistGoal.DataFormat();
                            readList[goalDone - 1] = checklistGoal.ReadFormat();
                        }

                        // tell the user how many points they earned, add those points to the total
                            Console.WriteLine(); // blank line
                            Console.WriteLine($"Congratulations! You have earned {addPoints} points!");
                            pointsTotal += addPoints;
                    }

                    break;

                // -------------
                // 6. erase goal
                // -------------
                case "6":

                    // list the goals
                    int erasePosition = 0;
                    Console.WriteLine("The goals are:");
                    foreach(string eraseName in names)
                    {
                        erasePosition += 1;
                        Console.WriteLine($"{erasePosition}. {eraseName}");
                    }

                    // ask which goal to erase
                    Console.Write("Which goal would you like to erase? ");
                    int goalErase = int.Parse(Console.ReadLine());

                    // erase the goal if it's within range, otherwise ignore
                    if (goalErase >= 1 && goalErase <= names.Count)
                    {
                        dataList.RemoveAt(goalErase - 1);
                        readList.RemoveAt(goalErase - 1);
                        names.RemoveAt(goalErase - 1);
                    }

                    break;
                
                // 7. quit
                default:
                    break;
            }
        }
    }
}