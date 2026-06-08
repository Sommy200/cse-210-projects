using System;
using System.Collections.Generic;
using Shapes; // This tells Program to look inside the Shapes namespace

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Square("Red", 5));
            // ... add the others ...

            foreach (Shape s in shapes)
            {
                Console.WriteLine($"Area: {s.GetArea()}");
            }
        }
    }
}