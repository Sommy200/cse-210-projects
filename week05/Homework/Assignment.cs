using System;

public class Assignment
{
    // using protected access modifier to allow derived classes to access these fields
    protected string _studentName;
    protected string _topic;

   // Constructor
    public Assignment(string studentName, string topic)

    {
        _studentName = studentName;
        _topic = topic;
    }

    // return a summary with student name and topic
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";

    }

    // public getter method to access the student name
    public string GetStudentName()
    {
        return _studentName;

    }
    

}