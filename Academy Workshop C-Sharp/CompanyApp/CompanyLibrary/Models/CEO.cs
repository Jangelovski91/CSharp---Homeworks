using System;
using CompanyLibrary.Enums;
using System.Collections.Generic;
using System.Text;

namespace CompanyLibrary.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees = new Employee[] { };
        public int Shares { get; set; }
        private double SharesPrice { get; set; }

        
        public CEO()
        {

        }
        public CEO(string firstName, string lastName, int shares, Employee[] emplooyes)
        {
            FirstName = firstName;
            LastName = lastName;
            Shares = shares;
            Salary = 15000;
            Role = RoleType.CEO;
            Employees = emplooyes;
        }
        public double addSharesPrice(double price)
        {
            return
            SharesPrice += price;
        }
        public void PrintEmplooyes()
        {
            Console.WriteLine(Employees);
        }
        public override double GetSalary()
        {
            return Salary += Shares * SharesPrice;
        }


    }
}
