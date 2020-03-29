using System;

namespace Project01
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime add3Days = DateTime.Today.AddDays(3);
            Console.WriteLine(add3Days);
            DateTime addOneMonth = DateTime.Today.AddMonths(1);
            Console.WriteLine(addOneMonth);
            DateTime add1M3D = DateTime.Today.AddMonths(1).AddDays(3);
            Console.WriteLine(add1M3D);
            DateTime Oney2mAgo = DateTime.Today.AddYears(-1).AddMonths(-2);
            Console.WriteLine(Oney2mAgo);
            DateTime currentMonth = DateTime.Now;
            Console.WriteLine( currentMonth.ToString("MMMM"));
            DateTime currentYear = DateTime.Now;
            Console.WriteLine(currentYear.ToString("yyyy"));




            Console.ReadLine();
        }
    }
}
