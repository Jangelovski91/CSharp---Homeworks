﻿using CompanyLibrary.Models;
using System;

namespace CompanyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Manager Max = new Manager("Max", "Jangelovski");
            Max.PrintInfo();
            Max.AddBonus(10000);
            Console.WriteLine("Max's new salary is" + " " + Max.GetSalary());
            Console.WriteLine("----------Salers----------------");
            SalesPerson Bob = new SalesPerson("Bob", "Bobsky");
            Bob.PrintInfo();
            Bob.ExtendSuccessRevenue(200);
            Console.WriteLine("Bob's new salary is" + " " + Bob.GetSalary());
            SalesPerson Pete = new SalesPerson("Pete", "Peterson");
            Pete.PrintInfo();
            Pete.ExtendSuccessRevenue(2500);
            Console.WriteLine("Pete's new salary is" + " " + Pete.GetSalary());
            SalesPerson Jan = new SalesPerson("Jan", "Janson");
            Jan.PrintInfo();
            Jan.ExtendSuccessRevenue(12000);
            Console.WriteLine("Bob's new salary is" + " " + Jan.GetSalary());
            Console.WriteLine("-------------------------------------------------");

            Manager Jack = new Manager("Jack", "Jackwell");
            Manager Janny = new Manager("Janny", "Jones");
            Contractor Marck = new Contractor("Marck", "Rodwell", Jack, 220);
            Contractor Cris = new Contractor("Cris", "Cole", Janny, 180);
            SalesPerson Andy = new SalesPerson("Andy", "Backman");

            Employee[] Company = { Marck, Cris, Jack, Janny, Andy };

            CEO bussinessCentar = new CEO("Bill", "Gates", 85, Company);
            bussinessCentar.PrintInfo();
            bussinessCentar.PrintEmplooyes();
            bussinessCentar.GetSalary();




            Console.ReadLine();
        }
    }
}
