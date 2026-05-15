
using System;
public class Entry
{
    public string _Date;
    public string _PromptText;
    public string _EntryText;

    public void Display()
    {
        Console.WriteLine($"Date: {_Date}");
        Console.WriteLine($"Prompt: {_PromptText}");
        Console.WriteLine($"Response: {_EntryText}");
        Console.WriteLine();
    }
}