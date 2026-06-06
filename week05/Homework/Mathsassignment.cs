
// MathsAssignment class inherits from Assignment
public class MathsAssignment : Assignment
{
   // private fields specific to MathsAssignment
    private string _textbookSection;
    private string _problems;

    // constructor takes all 4 parameters
    // the base keyword is used to call the constructor of the parent class (Assignment)

    public MathsAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }
      // return homework list specific to maths assignment
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} problems {_problems}";
    }
}