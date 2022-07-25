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

        public double CalculateCircumference()
        {
            return radius * 2 * Math.PI;
        }

        public string CalculateFormattedCircumference()
        {
            return FormatNumber(CalculateCircumference());
        }

        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }

        public string CalculateFormattedArea()
        {
            return FormatNumber(CalculateArea());
        }

        private static string FormatNumber(double x)
        {
            return Math.Round(x , 2).ToString();
        }
    }
}
