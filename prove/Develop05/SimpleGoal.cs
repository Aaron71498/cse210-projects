using System;

public class SimpleGoal : Goal
{
    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    // mark the goal as complete, add points to the total
    public override int RecordEvent()
    {
        IsComplete();
        return AddPoints();
    }

    // convert data to save format for txt file
    // save format - SimpleGoal:name|description|points|completion
    public override string SaveFormat()
    {
        return $"SimpleGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}";
    }

    // obtain required data from txt and convert front end data to reading format
    // reading format - [completion] name (description)
    public override string LoadFormat()
    {
        // write code here ---------------------------
        return;   
    }
}