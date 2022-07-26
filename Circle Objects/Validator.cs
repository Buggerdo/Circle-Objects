using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Objects
{
    internal class Validator
    {
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

        public static bool Continue()
        {
            Console.Write("Continue Y/N? ");
            string userInput = Console.ReadLine().ToLower().Trim();
            if("yes".StartsWith(userInput))
            {
                return true;
            }
            return false;
        }
    }
}
