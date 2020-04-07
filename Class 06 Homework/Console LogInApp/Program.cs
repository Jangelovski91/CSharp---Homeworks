using System;
using Console_LogInApp.Models;

namespace Console_LogInApp
{
    
    class Program
    {   static void Login(User[] users)
        {
            Console.WriteLine("Please enter your username.");
            string username = Console.ReadLine();
            Console.WriteLine("Now enter your password.");
            string password = Console.ReadLine();

            bool userWasFound = false;
            while (!userWasFound)
            {
                foreach(var user in users )
                {
                    if(username == user.Username && password == user.Password)
                    {
                        Console.WriteLine($"Welcome {user.Username}, you can read your messages:");
                        foreach(var sms in user.Messages)
                        {
                            Console.WriteLine(sms);
                        }
                    }
                    userWasFound = true;

                }
                break;
              
            }
            if (userWasFound)
            {
                Console.WriteLine("This user was not found, do you want to make an account?");
            }
        }

        static void Register(User[] users)
        {
            User newUser = new User();

            Console.WriteLine("Insert your ID here.");
            bool newId = int.TryParse(Console.ReadLine(), out int id);
            newUser.ID = id;

            Console.WriteLine("Insert your username here.");
            newUser.Username = Console.ReadLine();
            foreach(var user in users)
            {
                if (newUser.Username == "" || newUser.Username == user.Username)
                {
                    Console.WriteLine("Please insert correct username, or thisone is already taken.");
                }
                //e{lse
                
                    
                //}
            };
            Console.WriteLine("Insert your password here.");
            newUser.Password = Console.ReadLine();
            foreach(var user in users)
            {
                if(newUser.Password == "")
                {
                    Console.WriteLine("Please insert correct password.");
                }
                else
                {
                    Console.WriteLine(newUser.Password);
                }
            }
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = newUser;

            Console.WriteLine("Registration complete! Users:");

            foreach (var user in users)
            {
                Console.WriteLine($"{user.ID} {user.Username}");
            }
        }
        static void Main(string[] args)
        {
            User[] users = new User[]
            {
                  new User(1, "User1", "Pass1", new string[] {"Message N.1!", "Second message from user 1!"}),
                  new User(2, "User2", "Pass2", new string[] {"Message N. 1!", "Second message from user 2!" }),
                  new User(3, "User3", "Pass3",new string[] {"Message N.1!", "Second message from user 3!" }),
            };

            bool taskbarMeni = true;
            while (taskbarMeni)
            {

                Console.WriteLine(@"To Log In pres (1).    To register press (2).");
                bool parse = int.TryParse(Console.ReadLine(), out int chooseButton);


                switch (chooseButton)
                {
                    case 1:
                        {
                            Login(users);
                            taskbarMeni = false;
                            break;
                        }
                    case 2:
                        {
                            Register(users);
                            taskbarMeni = false;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }


            }

            Console.ReadLine();
        }
    }
}
