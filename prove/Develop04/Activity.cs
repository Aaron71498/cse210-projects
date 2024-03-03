using System;

class Activity
{
    // attributes
    private string _name;
    private string _description;
    private int _duration;

    // constructor
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // method to get the duration
    public int GetDuration()
    {
        return _duration;
    }

    // the message for the beginning of each activity
    public void StartMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine(); // blank line
        Console.WriteLine(_description);
        Console.WriteLine(); // blank line
        Console.Write("How long, in seconds, would you like for your session? ");
        
        _duration = int.Parse(Console.ReadLine()); // convert input to integer
        
        Console.Clear(); // clear console
        
        // get ready to start the activity
        Console.WriteLine("Get ready...");
        SpinnerPause(3);
        Console.WriteLine(); // blanke line
    }

    // the message for the end of each activity
    public void EndMessage()
    {
        Console.WriteLine("Well done!!");
        SpinnerPause(2);
        Console.WriteLine(); // next line
        Console.WriteLine($"You have completed at least {_duration} seconds of the {_name}.");
        SpinnerPause(2);
    }

    // method to animate a spinner
    public void SpinnerPause(int cycles)
    {
        while (cycles > 0)
        {
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            cycles -= 1; // minus one cycle
        }
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
    }

    // method for a countdown
    public void CountdownPause(int time)
    {
        while (time > 0)
        {
            Console.Write(time);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            time -= 1;
        }
    }
}