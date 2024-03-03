using System;

class BreathingActivity : Activity
{
    // constructor
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }

    // run the breathing activity
    public void RunBreathingActivity()
    {
        // get duration
        int duration = GetDuration();

        // run activity
        while (duration > 0)
        {
            Console.Write("Breathe in...");
            CountdownPause(4);
            Console.WriteLine(); // next line
            Console.Write("Now breathe out...");
            CountdownPause(4);
            duration -= 8;
            Console.WriteLine(); // next line
            Console.WriteLine(); // blank line
        }
    }
}