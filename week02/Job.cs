public class Job
{
    // These are the member variables (fields)
    // The underscore prefix is a naming convention for private fields
    public string _Company;
    public string _JobTitle;
    public int _StartYear;
    public int _EndYear;

    // This method displays the job information
    public void Display()
    {
        Console.WriteLine($"{_JobTitle}({_Company}) {_StartYear}- {_EndYear}");
    }
}