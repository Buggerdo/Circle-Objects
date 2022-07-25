namespace Circle_Objects
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            radius = radius;
        }

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public double CalculateCircumference()
        {
            return radius * 2 * Math.PI;
        }
        public string CalculateFormattedCircumference()
        {
            return (radius * 2 * Math.PI).ToString();
        }
        public double CalculateArea()
        {
            return radius * radius * Math.PI;
        }
        public string CalculateFormattedArea()
        {
            return (radius * radius * Math.PI).ToString();
        }
        private string FormatNumber(double x)
        {
            return x.ToString();
        }

    }
}
