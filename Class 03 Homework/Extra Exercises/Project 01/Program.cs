using System;

namespace Project_01
{
    class Program
    {
        static void Main(string[] args)
        {
            #region trafficLight

            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("STOP!");

            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("READY!");

            //Console.BackgroundColor = ConsoleColor.Green;
            //Console.WriteLine("GO!");


            #endregion

            #region Fizzbuzz

            //for (int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0 && i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz-buzz");
            //    } else if(i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }else if(i % 3 == 0) 
            //    {
            //        Console.WriteLine("Fizz");
            //    } else
            //    {
            //        Console.WriteLine(i);
            //    }

            //};

            #endregion

            #region digitComparer
            //for (int i = 10; i < 100; i++)
            //{
            //    int tens = i / 10;
            //    int ones = i % 10;
            //    if (tens > ones)
            //    {
            //        Console.WriteLine(i);


            #endregion

            #region nameOfMonth

            //Console.WriteLine("Enter the number for 1 to 12 to get your month.");
            //int month = int.Parse(Console.ReadLine());
            //switch(month)
            //{
            //    case 1:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("Juny");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("Septembar");
            //        break;
            //    case 10:
            //        Console.WriteLine("Oktombar");
            //        break;
            //    case 11:
            //        Console.WriteLine("Novembar");
            //        break;
            //    case 12:
            //        Console.WriteLine("Decembar");
            //        break;
            //        default:
            //        Console.WriteLine("Error, incorrect value!");
            //            break;
            //}

            #endregion

            #region coffeeMachine

            Console.WriteLine("Welcome dear customer, please select the drink you want:");
            Console.WriteLine();
            Console.WriteLine("1.Espresso...........2$");
            Console.WriteLine("2.Macchiato........3, 5$");
            Console.WriteLine("3.Latte..............4$");
            Console.WriteLine("4.Cappuccino.........6$");
            Console.WriteLine("5.Tea..............1.5$");

            double coffeePrice = 0;
            int customerMoney = 0;
            string userChoice;
            int Espresso = 2;
            double Macchiato = 3.5;
            int Latte = 4;
            int Cappuccino = 6;
            double Tea = 1.5;

            userChoice = Console.ReadLine();
            switch (userChoice)

            {
                case "1":
                    coffeePrice += Espresso;
                    Console.WriteLine("Espresso. 2$");
                    break;
                case "2":
                    coffeePrice += Macchiato;
                    Console.WriteLine("Macchiato. 3.5$");
                    break;
                case "3":
                    coffeePrice += Latte;
                    Console.WriteLine("Latte. 4$");
                    break;
                case "4":
                    coffeePrice += Cappuccino;
                    Console.WriteLine("Capuccino. 6$");
                    break;
                case "5":
                    coffeePrice += Tea;
                    Console.WriteLine("Tea. 1.5$");
                    break;
                default:
                    Console.WriteLine("Error, please select the correct number!");
                    break;
            };

            Console.WriteLine("choos your sweetnes level...(1-5 level)");
            int sugarLevel = int.Parse(Console.ReadLine());
            switch (sugarLevel)

            {
                case 1:
                    Console.WriteLine("No sugar...");
                    break;
                case 2:
                    Console.WriteLine("Half spoon sugar.");
                    break;
                case 3:
                    Console.WriteLine("One spoon sugar. ;)");
                    break;
                case 4:
                    Console.WriteLine("Sweet drink!");
                    break;
                case 5:
                    Console.WriteLine("Extra sweet drink! :D");
                    break;
            };

            Console.WriteLine("Please insert your cash...");
            customerMoney = int.Parse(Console.ReadLine());
            double missingMoney = coffeePrice - customerMoney;
            double restMoney = customerMoney - coffeePrice;
            if (customerMoney < coffeePrice)
            {
                Console.WriteLine("You dont have enough money,you are missing " + missingMoney + "$ to buy it.");
            }
            else if (customerMoney > coffeePrice)
            {
                Console.WriteLine("Enjoy your drink, and take your" + restMoney + "  $ rest money.");
            }
            else
            {
                Console.WriteLine("Enjoy your drink!");
            };

            #endregion

            Console.ReadLine();








        }
    }
}
