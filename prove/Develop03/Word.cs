using System;
using System.ComponentModel;

class Word
{
    // attributes
    private string _word;
    private bool _isVisible = true;

    // constructor
    public Word(string word)
    {
        _word = word;
    }

    // set visibility of the word
    public void SetVisibility(bool isvisible)
    {
        _isVisible = isvisible;
    }

    // display the word
    public string DisplayWord()
    {
        if (_isVisible == false)
        {
            return new string('-', _word.Length);
        }
        else
        {
            return _word;
        }

    }
}