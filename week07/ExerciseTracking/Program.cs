using System;
using System.Collections.Generic;
using ExerciseTracker;

class Program
{
    static void Main(string[] args)
    {
        // Create a list to hold all activities
        List<Activity> activities = new List<Activity>();

        // Create a running activity
        Running running = new Running("03 Nov 2022", 30, 3.0);
        activities.Add(running);

        // Create a cycling activity
        Cycling cycling = new Cycling("04 Nov 2022", 45, 15.0);
        activities.Add(cycling);

        // Create a swimming activity
        Swimming swimming = new Swimming("05 Nov 2022", 30, 20);
        activities.Add(swimming);

        // Create another running activity
        Running running2 = new Running("06 Nov 2022", 60, 5.0);
        activities.Add(running2);

        // Display all activities
        Console.WriteLine("=== EXERCISE TRACKER ===\n");
        
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}