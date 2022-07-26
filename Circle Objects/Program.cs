﻿namespace Circle_Objects
{
    internal class Program
    {
        public static string lineBreak = "====================================";
        static void Main()
        {
            List<Circle> circles = new();

            do
            {
                Console.Clear();
                Console.WriteLine(lineBreak);
                Console.WriteLine("Welcome to Troy's circle tester");
                Console.WriteLine(lineBreak);
                Console.WriteLine();
                Console.Write("Please enter the radius of a circle: ");

                if(Validator.UserInput(out double userInput))
                {
                    circles.Add(new Circle(userInput));
                }

            } while(Validator.Continue());
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(lineBreak);
            Console.WriteLine($"Goodbye! You made {circles.Count} circles.");
            Console.WriteLine($"With a total area of {Circle.FormatNumber(circles.Sum(n => n.CalculateArea()))}");
            Console.WriteLine(lineBreak);
        }
    }
}