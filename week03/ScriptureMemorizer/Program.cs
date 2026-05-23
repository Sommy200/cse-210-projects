using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a reference and scripture
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart and lean not unto thine own understanding in all thy ways acknowledge him and he shall direct thy paths";
        Scripture scripture = new Scripture(reference, scriptureText);

        // Main Loop 
        bool running = true;

        while (running)
        {
            // clear the console and display the scripture
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            // Check if scripture is completely hidden
            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("All words are hidden, great job memorizing!");
                Console.WriteLine("Press Enter key to exit...");
                Console.ReadLine();
                running = false; // leave the loop
                break;




            }

            // prompt user
            Console.WriteLine("Press Enter to hide more words, or type 'quit' to exit...");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                running = false; // leave the loop

            }
            else
            {
                scripture.HideRandomWords(3); // hide 3 more words
            }

        
        }

    }
}