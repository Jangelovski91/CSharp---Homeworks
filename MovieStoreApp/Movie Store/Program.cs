using Models_Library;
using Models_Library.Enums;
using Models_Library.Models;
using MovieStoreApp.Services;
using System;

namespace Movie_Store
{
   
    class Program
    {
        private static UserService _userService = new UserService();
        private static EmployeeService _employeeService = new EmployeeService();
        private static MovieService _movieService = new MovieService();
        private static HelperService _helperService = new HelperService();

        private static Member _loggedMember = null;
        //private static User _loggedUser = null;
        //private static Employee _loggedEmployee = null;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Cinemania movie store!");
                Console.WriteLine("For Login or Register as User press 1, as Employee press 2.");
                Console.WriteLine("(1) User");
                Console.WriteLine("(2) Employee");
                int userOrEmployeeOption = _helperService.ValidateInputNumber(Console.ReadLine(), 2);
                if (userOrEmployeeOption == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("Hi dear user! For Login press 1, so if You still dont have an account and You want to make please press 2.");
                        Console.WriteLine("(1) Login");
                        Console.WriteLine("(2) Register");
                        int userLoginOrRegister = _helperService.ValidateInputNumber(Console.ReadLine(), 2);

                        if (userLoginOrRegister == 1)
                        {

                            Console.WriteLine("Welcome back our dear customer!");
                            Console.WriteLine("Now enter your username.");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Now enter your password for login.");
                            string pass = Console.ReadLine();
                            _loggedMember = _userService.LogIn(userName, pass);
                            if (_loggedMember == null)
                            {
                                _helperService.Equals("Wrong username or password!");

                            }
                            else
                            {
                                Console.Clear();
                                break;

                            }
                        }

                        else if (userLoginOrRegister == 2)
                        {

                            Console.WriteLine("Please write the folowing information, and welcome in our movie world!");
                            Console.WriteLine("Now enter your Firstname.");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Now enter your Lastname.");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Now enter your username.");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Now enter your password for login.");
                            string pass = Console.ReadLine();

                            User newUser = new User(firstName, lastName, userName, pass);
                            _loggedMember = _userService.Register(newUser);

                            if (_loggedMember == null)
                            {
                                _helperService.ErrorMessage("Your registration was not succesfull, please try again.");

                            }
                            else
                            {
                                Console.Clear();
                                break;

                            }
                        }
                        else
                        {
                            _helperService.ErrorMessage("Wrong input, try again.");

                        };
                    }
                }

                else if (userOrEmployeeOption == 2)
                {
                    while (true)
                    {
                        Console.WriteLine("Hi! For Login press 1, so if You are new employee you should press 2 to create an account.");
                        Console.WriteLine("(1) Login");
                        Console.WriteLine("(2) Register");
                        int employeeLoginOrRegister = _helperService.ValidateInputNumber(Console.ReadLine(), 2);
                        if (employeeLoginOrRegister == 1)
                        {
                            Console.WriteLine("Welcome back!");
                            Console.WriteLine("Now enter your username.");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Now enter your password for login.");
                            string pass = Console.ReadLine();
                            _loggedMember = _employeeService.LogIn(userName, pass);
                            if (_loggedMember == null)
                            {
                                _helperService.ErrorMessage("Wrong username or password!");
                            }
                            else
                            {
                                Console.Clear();
                                break;

                            }
                        }
                        else if (employeeLoginOrRegister == 2)
                        {
                            Console.WriteLine("Please write the folowing information, and welcome in our movie world!");
                            Console.WriteLine("Now enter your Firstname.");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Now enter your Lastname.");
                            string lastName = Console.ReadLine();
                            Console.WriteLine("Now enter your username.");
                            string userName = Console.ReadLine();
                            Console.WriteLine("Now enter your password for login.");
                            string pass = Console.ReadLine();

                            Employee newEmployee = new Employee(firstName, lastName, userName, pass);
                            _loggedMember = _employeeService.Register(newEmployee);

                            if (_loggedMember == null)
                            {
                                _helperService.ErrorMessage("Your registration was not succesfull, please try again.");

                            }
                            else
                            {
                                Console.Clear();
                                break;

                            }
                        }
                        else
                        {
                            _helperService.ErrorMessage("Wrong input, try again.");
                        }
                    }
                }
                    
                else
                {
                    _helperService.ErrorMessage("Wrong input, try again.");
                    Console.Clear();
                    continue;
                }

                if(_loggedMember.Role == RoleType.User)
                {
                    _movieService.printAllMovies();
                }
                else if(_loggedMember.Role == RoleType.Employee)
                {
                    _userService.SeeAllUsers();
                }
                else
                {
                    _helperService.ErrorMessage("Something went wrong!");
                }
                //run again or end flow.-------------------------------------
                if (_helperService.RunAgain() == false) break;
                Console.Clear();


                Console.ReadLine();

            }

        }
    }
}
