    namespace Circle_Objects
{
    internal class Program
    {
        public static string lineBreak = "====================================";
        static void Main()
        {
            List<Circle> circles = new();

            Console.WriteLine(lineBreak);
            Console.WriteLine("Welcome to the circle creator");
            Console.WriteLine(lineBreak);
            Console.WriteLine();

            circles.Add(new Circle(102));

            Console.WriteLine();
            Console.WriteLine(lineBreak);
            Console.WriteLine($"Godbye! You made {circles.Count} circles");
            Console.WriteLine(lineBreak);
        }
    }
}