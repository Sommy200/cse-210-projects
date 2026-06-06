using System; 

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Homework Assignments ===");

        // testing the base assignment class
        Console.WriteLine("\n--- Base Assignment ---");
        Assignment simpleAssignment = new Assignment("Samuel Benneth", "Multiplication");
        Console.WriteLine(simpleAssignment.GetSummary());

        // testing the maths assignment class
        Console.WriteLine("\n--- Maths Assignment ---");
        MathsAssignment mathAssignment = new MathsAssignment("Sommy Roberts", "Fractions", "7.3", "8-19");
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();

        // testing the writing assignment class
        Console.WriteLine("\n--- Writing Assignment ---");
        WritingAssignment writingAssignment = new WritingAssignment("Mary Poppins", "Creative Writing", "the magical world of writting");
        

        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(writingAssignment.GetWritingInformation());
        Console.WriteLine();

        // test another math assignment
        Console.WriteLine("\n--- Another Maths Assignment ---");
        MathsAssignment anotherMathAssignment = new MathsAssignment("John Doe", "Algebra", "5.2", "1-10");

        Console.WriteLine(anotherMathAssignment.GetSummary());
        Console.WriteLine(anotherMathAssignment.GetHomeworkList());
        Console.WriteLine();

        // test another writing assignment
        Console.WriteLine("\n--- Another Writing Assignment ---");
        WritingAssignment anotherWritingAssignment = new WritingAssignment("Jane Smith", "Essay Writing", "the impact of technology on society");

        Console.WriteLine(anotherWritingAssignment.GetSummary());
        Console.WriteLine(anotherWritingAssignment.GetWritingInformation());
         



    }   
}