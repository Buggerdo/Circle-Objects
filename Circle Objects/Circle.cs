namespace Circle_Objects
{
    public class Circle
    {
        private readonly double radius;

        public double Radius
        {
            get { return radius; }
        }

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
        public double CalculateCircumference()
        {
            return radius * 2 * Math.PI;
        }

        /// <summary>
        /// Formats the circles circumference
        /// </summary>
        /// <returns>The formated circumference rounded to the secound decimal place</returns>
        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        /// <summary>
        /// Caculates the circles area
        /// </summary>
        /// <returns>The area of the circle</returns>
        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }

        /// <summary>
        /// Formats the area of the circle 
        /// </summary>
        /// <returns>The area of the circle rounded to the second decimal place</returns>
        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        /// <summary>
        /// Rounds the number to the second decimal place
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        private static string FormatNumber(double x)
        {
            return Math.Round(x , 2).ToString();
        }
    }
}
