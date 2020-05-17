using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Services
{
    public class HelperService
    {
        public int ValidateInputNumber(string number, int range)
        {
            int result = 0;
            bool isNumber = int.TryParse(number, out result);
            if (!isNumber)
            {
                Console.WriteLine("Input must be number, 1 or 2... Please try again.");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            if(result < 1 || result > range)
            {
                Console.WriteLine("The number is out of range... Please try again.");
                Console.ReadLine();
                Console.Clear();
                return -1;
            }
            return result;
        }
        public void ErrorMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
            Console.ReadLine();
            Console.Clear();

        }

        public bool RunAgain()
        {
            while(true)
            {
                Console.WriteLine("Would you like to run again: Y/N?");
                string answer = Console.ReadLine().ToLower();

                if (answer == "y") return true;
                if (answer == "n") return false;
            }
            
        }

    }
}
