using System;

class Assignment
{
    // attributes
    protected string _studentName;
    private string _topic;

    // constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // method to return name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}