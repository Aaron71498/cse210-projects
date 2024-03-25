using System;

class Comment
{
    // attributes
    private string _name;
    private string _text;

    // constructor
    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    // method to combine name and text
    public string MakeComment()
    {
        return $"{_name}: {_text}";
    }
}