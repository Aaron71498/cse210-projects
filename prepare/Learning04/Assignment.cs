using System;

class Assignment
{
    // attributes
    private string _studentName;
    private string _topic;

    // constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // getter for student name
    public string GetStudentName()
    {
        return _studentName;
    }

    // method to return name and topic
    public string GetSummary()
    {
        return _studentName + " - " + _topic;
    }
}