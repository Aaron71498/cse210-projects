using System;

public class EternalGoal : Goal
{
    // constructor
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {}

    // ---------
    // Behaviors
    // ---------

    // add points to the total for completing an instance of the goal
    public override int RecordEvent()
    {
        return AddPoints();
    }

    // convert data to save format for txt file
    // save format - EternalGoal|name|description|points
    public override string DataFormat()
    {
        return $"EternalGoal|{GetName()}|{GetDescription()}|{GetPoints()}";
    }
}