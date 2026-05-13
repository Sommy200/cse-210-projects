using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Resume myResume = new Resume();
        myResume._Name = "John Doe";

        Job job1 = new Job();
        job1._Company = "Microsoft";
        job1._JobTitle = "Software Engineer";
        job1._StartYear = 2015;
        job1._EndYear = 2020;

        Job job2 = new Job();
        job2._Company = "Apple";
        job2._JobTitle = "Senior Software Engineer";
        job2._StartYear = 2020;
        job2._EndYear = 2024;

        myResume._Jobs.Add(job1);
        myResume._Jobs.Add(job2);

        myResume.Display();
    }
}

class Job
{
    public string _Company;
    public string _JobTitle;
    public int _StartYear;
    public int _EndYear;
}

class Resume
{
    public string _Name;
    public List<Job> _Jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_Name}");
        Console.WriteLine("Jobs:");
        foreach (Job job in _Jobs) 
        {
            Console.WriteLine($"{job._JobTitle}  ({job._Company}) {job._StartYear} - {job._EndYear}");
        }
    }
}