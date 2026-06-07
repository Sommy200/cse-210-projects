using System;
using System.Collections.Generic;

namespace Mindfulness // This connects this file to your other files
{
    public class ListingActivity : Activity
    {
        private List<string> _prompts;

        // Constructor: Note that we don't need to pass 'name' and 'description' 
        // as arguments here because we are hardcoding them in the base() call.
        public ListingActivity() 
            : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
        {
            _prompts = new List<string> 
            {
                "Who are people that you appreciate?",
                "What are personal strengths of yours?",
                "Who are people that you have helped this week?",
                "When have you felt the Holy Ghost this month?",
                "Who are some of your personal heroes?"
            };
        }

        public void Run()
        {
            DisplayStartingMessage();

            Console.WriteLine("List as many responses as you can to the following prompt:");
            Console.WriteLine();
            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.WriteLine();

            Console.Write("You may begin in: ");
            ShowCountdown(5);
            Console.WriteLine();
            Console.WriteLine();

            List<string> items = new List<string>();
            
            DateTime startTime = DateTime.Now;
            DateTime endTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < endTime)
            {
                Console.Write("> ");
                string item = Console.ReadLine() ?? ""; // Fixes the CS8600 warning
                
                if (!string.IsNullOrWhiteSpace(item))
                {
                    items.Add(item);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"You listed {items.Count} items!");

            DisplayEndingMessage();
        }

        private string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}


