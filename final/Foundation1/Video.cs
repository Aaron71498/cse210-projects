using System;

class Video
{
    // attributes
    private string _title;
    private string _author;
    private int _seconds;
    private List<Comment> _comments = new List<Comment>();

    // constructor
    public Video(string title, string author, int seconds)
    {
        _title = title;
        _author = author;
        _seconds = seconds;
    }

    // method to add to the comments list
    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    // method to count number of items in comments list
    public int CountComments()
    {
        return _comments.Count();
    }

    // method to list comments
    public void ListComments()
    {
        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.MakeComment());
        }
    }

    // method to display video info
    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length (in seconds): {_seconds}");
        Console.WriteLine(); // blank line
        Console.WriteLine($"Comments: {CountComments()}");
        ListComments();
    }
}