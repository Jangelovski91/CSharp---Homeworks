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
        public bool ValidateStringLength(string value, int range)
        {
            int maxValue = 20;
            if(value.Length < range && range < maxValue)
            {
                return false;
            }
           
                return true;
        }
        

        public bool ValidatePassword(string password)
        {
            if (password.Length < 7) return false;

            char[] characters = password.ToCharArray();
            bool hasNumbers = false;
            foreach (char character in characters)
            {
                int num = 0;
                if (int.TryParse(character.ToString(), out num))
                {
                    hasNumbers = true;
                    break;
                }
            }
            if (!hasNumbers) return false;

            return true;

        }
       

    }
}
