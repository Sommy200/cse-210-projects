using System;

public class Comment
{
    // Private fields - encapsulated data
    private string _commenterName;
    private string _commentText;

    // Constructor
    public Comment(string CommenterName, string CommentText)
    {
        _commenterName = CommenterName;
        _commentText = CommentText;
    }
    public string GetDisplayText()
    {
        return $"{_commenterName}: {_commentText}";
    }
}