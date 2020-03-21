using System;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Please enter the first number.");
			int firstNum = int.Parse(Console.ReadLine());

			Console.WriteLine("Please enter the second number.");
			int secondNum = int.Parse(Console.ReadLine());

			Console.WriteLine("Please write the operation you want to use - +, - , * or / .");

			int sum = 0;

			string operationRandom = Console.ReadLine();
			switch (operationRandom)
			{
				case "-":
					sum = firstNum - secondNum;
					Console.WriteLine(sum + " e vasiot rezultat.");
					break;
				case "+":
					sum = firstNum + secondNum;
					Console.WriteLine(sum + " e vasiot rezultat.");
					break;
				case "*":
					sum = firstNum * secondNum;
					Console.WriteLine(sum + " e vasiot rezultat.");
					break;
				case "/":
					sum = firstNum / secondNum;
					Console.WriteLine(sum + "e vasiot rezultat.");
					break;
				default:
					Console.WriteLine("wrong operation!");
					break;
			};

			Console.ReadLine();
        }
    }
}
