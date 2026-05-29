using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author; 
    private int _lengthInSeconds;
    private List<Comment> _comments;
    // Constructor
    public Video(string title, string author, int lenghtInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lenghtInSeconds;
        _comments = new List<Comment>();


     
    }
    // Method to add a comment
    public void AddComment(string commenterName, string commentText)
    {
        Comment comment = new Comment(commenterName, commentText);
        _comments.Add(comment);
    }
    // returns the number of comments
    public int GetCommentCount()
    {
        return _comments.Count;
    }
    // return video formatted information
    private string GetFormattedLength()
    {
        int minutes = _lengthInSeconds / 60;
        int seconds = _lengthInSeconds % 60;
        return $"{minutes}:{seconds:D2}";
    }
    // Method to display video and all its comments
    public void Display()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Length: {GetFormattedLength()} ({_lengthInSeconds} seconds)");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine($"- {comment.GetDisplayText()}");

        }
        Console.WriteLine(); // blankline between the videos
    }


}