namespace Circle_Objects
{
    internal class Validator
    {
        /// <summary>
        /// Validates user input
        /// </summary>
        /// <param name="x">returns a double if input is valid</param>
        /// <returns>returns true if input is valid</returns>
        public static bool UserInput(out double x)
        {
            try
            {
                x = double.Parse(Console.ReadLine());
                if (x > 0) { return true; }
                return false;
            }
            catch(Exception)
            {
                Console.WriteLine("That is not a valid input.");
                x = 0;
                return false;
            }
        }

        /// <summary>
        /// Askes the user if they want to continue
        /// </summary>
        /// <returns>True if the user wants to continue</returns>
        public static bool Continue()
        {
            Console.Write("Continue Y/N? ");
            string userInput = Console.ReadLine().ToLower().Trim();
            if(userInput != String.Empty && "yes".StartsWith(userInput))
            {
                return true;
            }
            return false;
        }
    }
}
