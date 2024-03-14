using System;

public class SimpleGoal : Goal
{
    // constructor
    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {}

    // ---------
    // Behaviors
    // ---------

    // mark the goal as complete, add points to the total
    public override int RecordEvent()
    {
        IsComplete();
        return AddPoints();
    }

    // convert data to save format for txt file
    // save format - SimpleGoal|name|description|points|completion
    public override string DataFormat()
    {
        return $"SimpleGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{GetIsComplete()}";
    }
}