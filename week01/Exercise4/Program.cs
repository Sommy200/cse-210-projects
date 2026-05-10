using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();
        
        Console.WriteLine("enter a list of numbers, type 0 when finished :");
        Console.Write("Enter a number: ");
        int userInput = int.Parse(Console.ReadLine());
        while (userInput != 0)
        {
            numberList.Add(userInput);
            Console.Write("Enter a number: ");
            userInput = int.Parse(Console.ReadLine());
        }
        int sum = 0;
        foreach (int number in numberList)
        {
            sum += number;
        }
        

        double average = (double)sum / numberList.Count;

        int largest = numberList[0];
        foreach (int number in numberList)
        {
            if (number > largest)
            {
                largest = number;
            }
        }

       
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}