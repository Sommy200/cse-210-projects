using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor - takes reference and full scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

       // Split the text into individual words and create Word objects
        string[] wordArray = text.Split(' ');
        foreach (string wordText in wordArray)
        {
            _words.Add(new Word(wordText));
        }
    }


    // Method to hide a random word
    public void HideRandomWords(int numberToHide)
    {
        // Create a random number generator
        Random random = new Random(); 
        // count
        int hiddenCount = 0;

       
        // Keep trying until we've hidden the requested number
        while (hiddenCount < numberToHide && !IsCompletelyHidden())
        {
            int index = random.Next(_words.Count);


            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }

    }
    public string GetDisplayText()
    {
        string displaytext = _reference.GetDisplayText() + "\n\n";
        foreach (Word word in _words)
        {
            displaytext += word.GetDisplayText() + " ";
        }
        return displaytext.Trim(); // remove trailing space

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}