using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise02
{
    class Program
    {

        static void Main(string[] args)
        {
            
            //DateTime inputDate;
            Console.WriteLine("Check the date! In this format - yyyy / MM / dd." );

            if (!DateTime.TryParse($@"{Console.ReadLine()}", out DateTime inputDate))
            {
                throw new FormatException("The Date you entered is not a valid date");
            }

            Console.WriteLine($"{inputDate.ToString("yyyy/MM/dd")}");

            if (inputDate.DayOfWeek == DayOfWeek.Saturday || inputDate.DayOfWeek == DayOfWeek.Sunday)
            {
                Console.WriteLine("...is weekend you can relax!");
            }
            else
            {
                Console.WriteLine("Its not weekend...");
            }
            List<DateTime> Holidays = new List<DateTime>
            {
                new DateTime(inputDate.Year, 01, 01),
                new DateTime(inputDate.Year, 01, 07),
                new DateTime(inputDate.Year, 04, 15),
                new DateTime(inputDate.Year, 05, 01),
                new DateTime(inputDate.Year, 05, 24),
                new DateTime(inputDate.Year, 08, 02),
                new DateTime(inputDate.Year, 09, 08),
                new DateTime(inputDate.Year, 10, 11),
                new DateTime(inputDate.Year, 10, 23),
                new DateTime(inputDate.Year, 12, 08)

            };

            foreach (var item in Holidays)
            {
                if(item.Day == inputDate.Day && item.Month == inputDate.Month)
                {
                    Console.WriteLine("But is Holiday!");
                    break;
                }
        
            }

            //var chechedDate = Holidays
            //                        .Where(d => d.Day == inputDate.Day && d.Month == inputDate.Month)
            //                        .SingleOrDefault();

            //if ( chechedDate == null)
            //{
            //    Console.WriteLine("is not holiday.");
            //}
            //else
            //{
            //    Console.WriteLine("is holiday");

            Console.ReadLine();

        }



    }


}
    

   

