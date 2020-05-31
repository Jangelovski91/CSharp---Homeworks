using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieStoreApp.Services
{
    public class EmployeeService
    {
        private HelperService _helperService = new HelperService();

        public List<Employee> Employees { get; set; }

        public EmployeeService()
        {
            Employees = new List<Employee>
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
            if (!_helperService.ValidateStringLength(employee.FirstName, 2) ||
                !_helperService.ValidateStringLength(employee.LastName, 2) ||
                !_helperService.ValidateStringLength(employee.UserName, 5))
            {
                return null;
            }
            if (!_helperService.ValidatePassword(employee.Password)) return null;

            Employees.Add(employee);

            return
                Employees.LastOrDefault();
        }


        
    }

    
}
