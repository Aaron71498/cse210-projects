using System;

public class ChecklistGoal : Goal
{
    // attributes
    private int _numberDone = 0;
    private int _numberNeeded;
    private int _completionBonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int completionBonus, int numberNeeded, int numberDone = 0) : base(name, description, points)
    {
        _numberNeeded = numberNeeded;
        _completionBonus = completionBonus;
        _numberDone = numberDone;
    }

    // ---------
    // Behaviors
    // ---------

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
    // save format - ChecklistGoal|name|description|points|number needed|number done|completion bonus|completion
    public override string DataFormat()
    {
        return $"ChecklistGoal|{GetName()}|{GetDescription()}|{GetPoints()}|{_completionBonus}|{_numberNeeded}|{_numberDone}|{GetIsComplete()}";
    }

    // obtain required data from txt and convert front end data to reading format
    // reading format - [completion] name (description) -- Currently completed: number done/number needed
    public override string ReadFormat()
    {
        string completion;
        
        if (GetIsComplete() == true)
        {
            completion = "X";
        }
        else
        {
            completion = " ";
        }

        return $"[{completion}] {GetName()} ({GetDescription()}) -- Currently completed: {_numberDone}/{_numberNeeded}"; 
    }
}