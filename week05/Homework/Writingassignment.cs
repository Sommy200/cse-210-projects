

// inherits from Assignment
public class WritingAssignment : Assignment
{
    // private field specific to WritingAssignment
    private string _title;
   // constructor takes all 3 parameters
   // pass name and topic to the base class constructor
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
        // return writing information with title and student name
        

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}