using System;

public class Word
{
    // Private fields - encapsulated data
    private string _text;
    private bool _isHidden;

    // Constructor- takes the word to text

    public Word (string text)
    {
        _text = text;
        _isHidden = false; // default to not hidden
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to show the word
    public void Show()
    {
        _isHidden = false;
    }

    // returns true if word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // method to get display text- either word or underscore
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            //return underscores matching the lenght of the word
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }



}


     