using System;

namespace Project02
{
    class Program
    {
        static double Sum(double number1, double number2)
        {

            return
                number1 + number2;
        }

        static double Subtract(double number1, double number2)
        {

            return
                number1 - number2;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter + or - operation.");
            string Operation = Console.ReadLine();
            if (Operation != "+" && Operation != "-")
            {

                Console.WriteLine("Wrong input!");
            }
            else if (Operation == "+")
            {
                Console.WriteLine($"You chose {Operation} operation.");
                Console.WriteLine("Enter your first number.");
                int number1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int number2 = int.Parse(Console.ReadLine());
                double resultPlus = Sum(number1, number2);
                Console.WriteLine($"Your result is {resultPlus}.");

            }
            else
            {
                Console.WriteLine($"You chose {Operation} operation.");
                Console.WriteLine("Enter your first number.");
                int num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter your second number.");
                int num2 = int.Parse(Console.ReadLine());
                double resultMinus = Subtract(num1,num2);
                Console.WriteLine($"Your result is {resultMinus}.");
            }




            Console.ReadLine();
        }

    }
}
