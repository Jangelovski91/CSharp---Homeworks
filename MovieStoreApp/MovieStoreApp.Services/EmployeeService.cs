using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Services
{
    public class EmployeeService
    {
        public Employee[] Employees { get; set; }

        public EmployeeService()
        {
            Employees = new Employee[]
            {
                new Employee("Ben", "Benski", 31, "ben_ten","ben123", new DateTime(2019/07/15),180),
                new Employee("Ana", "Iverson", 29, "ana_iv","ana123", new DateTime(2018/01/28),240)
            };
        }
        public Employee LogIn(string username, string password)
        {
            foreach (Employee employee in Employees)
            {
                if (employee.UserName == username && employee.Password == password)
                {
                    return employee;
                }
            }
            return null;
        }

        public Employee Register(Employee employee)
        {
            Employee[] registeredEmployees = Employees;
            Array.Resize(ref registeredEmployees, registeredEmployees.Length + 1);
            registeredEmployees[registeredEmployees.Length - 1] = employee;
            Employees = registeredEmployees;

            return
                Employees[Employees.Length - 1];
        }

        
    }

    
}
