using System;

public abstract class Goal
{
    // attributes
    private string _name;
    private string _description;
    private int _points;
    private bool _isComplete = false;

    // constructor
    public Goal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    // ---------
    // Behaviors
    // ---------

    // getters
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public int GetPoints()
    {
        return _points;
    }
    public bool GetIsComplete()
    {
        return _isComplete;
    }

    // mark goal as complete
    public void IsComplete()
    {
        _isComplete = true;
    }

    // add points from the goal
    public int AddPoints()
    {
        return _points;
    }

    // record an occurrence of the goal
    public abstract int RecordEvent();

    // convert data into save format for txt file
    public abstract string DataFormat();

    // obtain required data from txt and convert front end data to reading format
    // reading format - [completion] name (description)
    public virtual string ReadFormat()
    {
        string completion;

        if (_isComplete == true)
        {
            completion = "X";
        }
        else
        {
            completion = " ";
        }

        return $"[{completion}] {_name} ({_description})";
    }
}