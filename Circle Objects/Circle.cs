﻿namespace Circle_Objects
{
    public class Circle
    {
        private readonly double radius;

        public Circle(double radius)
        {
            this.radius = radius;

            Console.WriteLine();
            Console.WriteLine(Program.lineBreak);
            Console.WriteLine($"You entered a radius of: {radius}");
            Console.WriteLine($"Circumference:           {CalculateFormattedCircumference()}");
            Console.WriteLine($"Area:                    {CalculateFormattedArea()}");
            Console.WriteLine(Program.lineBreak);
            Console.WriteLine();
        }

        /// <summary>
        /// Caculates circle circumference
        /// </summary>
        /// <returns>The circumference of the circle</returns>
        public double CalculateCircumference() => radius * 2 * Math.PI;

        /// <summary>
        /// Formats the circles circumference
        /// </summary>
        /// <returns>The formated circumference rounded to the secound decimal place</returns>
        public string CalculateFormattedCircumference() => FormatNumber(CalculateCircumference());

        /// <summary>
        /// Caculates the circles area
        /// </summary>
        /// <returns>The area of the circle</returns>
        public double CalculateArea() => radius * radius * Math.PI;

        /// <summary>
        /// Formats the area of the circle 
        /// </summary>
        /// <returns>The area of the circle rounded to the second decimal place</returns>
        public string CalculateFormattedArea() => FormatNumber(CalculateArea());

        /// <summary>
        /// Rounds the number to the second decimal place
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public static string FormatNumber(double x) => Math.Round(x, 2).ToString("N");
    }
}
