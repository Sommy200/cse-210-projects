using System;
using System.Collections.Generic;
using System.IO;

namespace EternalQuest
{
    public class GoalManager
    {
        private List<Goal> _goals;
        private int _score;

        public GoalManager()
        {
            _goals = new List<Goal>();
            _score = 0;
        }

        public void Start()
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                DisplayPlayerInfo();
                
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("  1. Create New Goal");
                Console.WriteLine("  2. List Goals");
                Console.WriteLine("  3. Save Goals");
                Console.WriteLine("  4. Load Goals");
                Console.WriteLine("  5. Record Event");
                Console.WriteLine("  6. Quit");
                Console.Write("Select a choice from the menu: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        CreateGoal();
                        break;
                    case "2":
                        ListGoalDetails();
                        break;
                    case "3":
                        SaveGoals();
                        break;
                    case "4":
                        LoadGoals();
                        break;
                    case "5":
                        RecordEvent();
                        break;
                    case "6":
                        running = false;
                        Console.WriteLine("Goodbye! Keep working on your Eternal Quest!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        System.Threading.Thread.Sleep(2000);
                        break;
                }
            }
        }

        private void DisplayPlayerInfo()
        {
            Console.WriteLine($"You have {_score} points.\n");
        }

        private void CreateGoal()
        {
            Console.Clear();
            Console.WriteLine("The types of Goals are:");
            Console.WriteLine("  1. Simple Goal");
            Console.WriteLine("  2. Eternal Goal");
            Console.WriteLine("  3. Checklist Goal");
            Console.Write("Which type of goal would you like to create? ");
            
            string goalType = Console.ReadLine();

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();
            
            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();
            
            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            switch (goalType)
            {
                case "1":
                    _goals.Add(new SimpleGoal(name, description, points));
                    break;
                case "2":
                    _goals.Add(new EternalGoal(name, description, points));
                    break;
                case "3":
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int target = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonus = int.Parse(Console.ReadLine());
                    _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                    break;
                default:
                    Console.WriteLine("Invalid goal type.");
                    break;
            }
        }

        private void ListGoalDetails()
        {
            Console.Clear();
            Console.WriteLine("The goals are:");
            
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet. Create one to get started!");
            }
            else
            {
                for (int i = 0; i < _goals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
                }
            }
            
            Console.WriteLine("\nPress Enter to return to menu...");
            Console.ReadLine();
        }

        private void SaveGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                outputFile.WriteLine(_score);
                foreach (Goal goal in _goals)
                {
                    outputFile.WriteLine(goal.GetStringRepresentation());
                }
            }
            
            Console.WriteLine($"Goals saved to {filename}");
            System.Threading.Thread.Sleep(2000);
        }

        private void LoadGoals()
        {
            Console.Write("What is the filename for the goal file? ");
            string filename = Console.ReadLine();

            if (!File.Exists(filename))
            {
                Console.WriteLine("File not found.");
                System.Threading.Thread.Sleep(2000);
                return;
            }

            _goals.Clear();
            string[] lines = File.ReadAllLines(filename);
            _score = int.Parse(lines[0]);
            
            for (int i = 1; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(':');
                string goalType = parts[0];
                string[] details = parts[1].Split(',');

                switch (goalType)
                {
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(details[0], details[1], int.Parse(details[2]), bool.Parse(details[3])));
                        break;
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(details[0], details[1], int.Parse(details[2])));
                        break;
                    case "ChecklistGoal":
                        _goals.Add(new ChecklistGoal(details[0], details[1], int.Parse(details[2]), int.Parse(details[3]), int.Parse(details[4]), int.Parse(details[5])));
                        break;
                }
            }
            
            Console.WriteLine($"Goals loaded from {filename}");
            System.Threading.Thread.Sleep(2000);
        }

        private void RecordEvent()
        {
            Console.Clear();
            Console.WriteLine("The goals are:");
            
            if (_goals.Count == 0)
            {
                Console.WriteLine("No goals yet. Create one to get started!");
                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].GetShortName()}");
            }
            
            Console.Write("\nWhich goal did you accomplish? ");
            int goalIndex = int.Parse(Console.ReadLine()) - 1;

            if (goalIndex >= 0 && goalIndex < _goals.Count)
            {
                int pointsEarned = _goals[goalIndex].RecordEvent();
                _score += pointsEarned;
                
                Console.WriteLine($"\nCongratulations! You earned {pointsEarned} points!");
                Console.WriteLine($"You now have {_score} points.");
                Console.WriteLine("\nPress Enter to return to menu...");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid goal number.");
                System.Threading.Thread.Sleep(2000);
            }
        }
    }
}