using System.Threading.Tasks.Dataflow;
using system.collections.Generic;

public class Resume
{
    public string _Name;
    // This creates an empty list ready to hold Job objects
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");
        // This loop goes through each Job in the _Jobs list and calls its Display method
        foreach (Job job in _Jobs)
        {
            job.Display();
        }
    }
}