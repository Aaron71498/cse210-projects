using System;

public class ChecklistGoal : Goal
{
    // attributes
    private int _numberDone = 0;
    private int _numberNeeded;
    private int _completionBonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int numberNeeded, int completionBonus) : base(name, description, points)
    {
        _numberNeeded = numberNeeded;
        _completionBonus = completionBonus;
    }

    // add one instance to the count of times done, add points,
    // if goal is complete, mark as complete and add bonus points
    public override int RecordEvent()
    {
        _numberDone += 1;

        if (_numberDone == _numberNeeded)
        {
            IsComplete();
            return AddPoints() + _completionBonus;
        }
        else
        {
            return AddPoints();
        }
    }

    // convert data to save format for txt file
    // save format - ChecklistGoal:name|description|points|completion bonus|number needed|number done|completion
    public override string SaveFormat()
    {
        return $"ChecklistGoal:{GetName()}|{GetDescription()}|{GetPoints()}|{_completionBonus}|{_numberNeeded}|{_numberDone}";
    }

    // obtain required data from txt and convert front end data to reading format
    // reading format - [completion] name (description) -- Currently completed: number done/number needed
    public override string LoadFormat()
    {
        // write code here ---------------------------
        return;   
    }
}