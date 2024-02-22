using System;

class WritingAssignment : Assignment
{
    // attribute
    private string _title;

    // constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }

    // method to return writing assignment
    public string GetWritingInformation()
    {
        string name = GetStudentName();
        return _title + " by " name;
    }
}