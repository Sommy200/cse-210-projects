using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade in percentage?: ");
        int grade = int.Parse(Console.ReadLine());
        string letterGrade = "";
        if (grade >= 90) 
        {
            letterGrade = "A";
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine("Congratulations you passed the course!");
       
        }
        else if (grade >= 80)
        {
            letterGrade = "B";
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine("Congratulations you passed the course!");
        }
        else if (grade >= 70)
        {
            letterGrade = "C";
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine("Congratulations you passed the course!");
        }
        else if (grade >= 60)
        {
            letterGrade = "D";
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine("You failed the course, but you can try again!");
        }
        else
        {
            letterGrade = "F";
            Console.WriteLine($"Your grade is {letterGrade}");
            Console.WriteLine("You failed the course, and you will need to retake it.");
        }
    }
}