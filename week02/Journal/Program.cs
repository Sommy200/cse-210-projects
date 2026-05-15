using System;

class Program
{
    static void Main(string[] args)
    {
        // Create one Journal object we'll use throughout the program
        Journal journal = new Journal();

       // Create one PromptGenerator we'll reuse
        PromptGen promptGen = new PromptGen();

        // This variable controls our menu loop
        bool running = true;
        while (running)
        {
             Console.WriteLine("Welcome to the Journal Program!");
             Console.WriteLine("Please select one of the following options:");
             Console.WriteLine("1. Write");
             Console.WriteLine("2. Display");
             Console.WriteLine("3. Load");
             Console.WriteLine("4. Save"); 
             Console.WriteLine("5. Quit");
             

             Console.Write("What would you like to do? ");
             string choice = Console.ReadLine();

             // Act based on their choice
             switch (choice)
            {
                case "1":
                    // Handle Write option
                    journal.AddEntry(promptGen);  
                    break;
                case "2":
                    // Handle Display option
                    journal.DisplayAll();
                    break;
                case "3":
                    // Handle Load option
                    journal.LoadFromFile();
                    break;
                case "4":
                    // Handle Save option
                    journal.SaveToFile();
                    break;
                case "5":
                    // Handle Quit option
                    running = false;
                    Console.WriteLine("Thank you for using the Journal Program!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }



        }

    }
}