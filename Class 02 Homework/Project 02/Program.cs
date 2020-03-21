using System;

namespace Project_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the first number.");
            int firstNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the second number.");
            int secondNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the third number.");
            int thirdNum = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the fourth number.");
            int fourthNum = int.Parse(Console.ReadLine());



            double sum = (firstNum + secondNum + thirdNum + fourthNum) / 4;

            Console.WriteLine("The averge sum is" + sum);

            Console.ReadLine();
        }
    }
}
