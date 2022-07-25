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
        }

        public double CalculateCircumference()
        {
            return (radius * 2) * Math.PI;
        }
        public string CalculateFormattedCircumference()
        {
            return (Math.Round(CalculateCircumference(), 2)).ToString();
        }
        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }
        public string CalculateFormattedArea()
        {
            return (Math.Round(CalculateArea(), 2)).ToString();
        }
        private static string FormatNumber(double x)
        {
            return x.ToString();
        }

    }
}
