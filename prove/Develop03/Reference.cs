using System;

class Reference
{
    // attributes
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse = "";

    // constructor for single-verse scripture
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter.ToString();
        _startVerse = verse.ToString();
    }

    // constructor for multi-verse scripture
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter.ToString();
        _startVerse = startVerse.ToString();
        _endVerse = "-" + endVerse.ToString();
    }

    // construct a complete reference
    public string ConstructReference()
    {
        return $"{_book} {_chapter}:{_startVerse}{_endVerse}";
    }
}