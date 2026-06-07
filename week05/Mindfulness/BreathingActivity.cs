using System;
using System.Threading;

namespace Mindfulness
{
    public class BreathingActivity : Activity
    {
        // Parameterless constructor makes it easier to instantiate in Program.cs
        public BreathingActivity() 
            : base("Breathing Activity", "This activity will help you relax through breathing in and out slowly. Clear your mind and focus on your breathing.")
        {
        }

        public void Run()
        {
            DisplayStartingMessage();

            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);
            
            while (DateTime.Now < endTime)
            {
                Console.WriteLine();
                Console.Write("Breathe in...");
                ShowCountdown(4);
                Console.WriteLine();

                Console.Write("Now breathe out...");
                ShowCountdown(6);
                Console.WriteLine();
            }

            DisplayEndingMessage();
        }
    }
}