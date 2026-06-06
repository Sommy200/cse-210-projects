using System;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu:");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity(); breathingActivity.Run();

                    
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity(); reflectionActivity.Run();
                    break;
                case "3":
                    ListingActivity listingActivity = new ListingActivity(); listingActivity.Run();
                    
                    break;
                case "4":
                    running = false;
                    Console.WriteLine("Thank you for using the mindfulness application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice.please select a valid option from 1-4");
                    System.Threading.Thread.Sleep(2000);
                    break;

            }
        }
    }
}