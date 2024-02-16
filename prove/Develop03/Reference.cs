using System;

class Reference
{
    // attributes
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse = "";

    // constructor for single-verse scripture
    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }

    // constructor for multi-verse scripture
    public Reference(string book, string chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = "-" + endVerse;
    }

    // methods for setting end verse
    public void SetEndVerse(string endVerse)
    {
        if (endVerse != "")
        {
            _endVerse = "-" + endVerse;
        }
    }

    // construct a complete reference
    public string ConstructReference()
    {
        return $"{_book} {_chapter}:{_startVerse}{_endVerse}";
    }
}