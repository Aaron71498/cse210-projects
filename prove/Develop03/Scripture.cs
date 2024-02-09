using System;

class Scripture
{
    // attributes
    private string _reference;
    private string _scripture;

    // constructor
    public Scripture(string reference, string scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }

    // convert scripture into list
    public List<string> StringToList()
    {
        return _scripture.Split(" ").ToList();
    }
}