using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int magicNumber = randomgenerator.Next(1, 101);

        int guessCount = 0;
        Console.Write("What is your guess? ");
        int userGuess = int.Parse(Console.ReadLine());
        while (userGuess != magicNumber)
        {
        guessCount++;

        
             if (userGuess == magicNumber)
           {
                Console.WriteLine("You guessed it!");
            }
             else if (userGuess < magicNumber)
           {
                Console.WriteLine("Higher");

           }
             else
           {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            userGuess = int.Parse(Console.ReadLine());

             guessCount++;
        }
         Console.WriteLine("You guessed it!");
         Console.WriteLine($"It took you {guessCount} guesses.");
    }
}