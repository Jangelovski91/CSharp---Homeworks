using Models_Library.Enums;
using Models_Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieStoreApp.Services
{
    public class UserService
    {
        public User[] Users { get; set; }
        public UserService()
        {
            Users = new User[]
            {

                new User()
                {
                    FirstName = "Nina",
                    LastName = "Panina",
                    Age = 19,
                    UserName = "nina_panina",
                    Password = "nina123",
                    DateOfRegistration = new DateTime(2019, 10, 10),
                    MemberNumber = 213,
                    Subscription = SubscriptionType.Annually
                },
                new User("Bob", "Bobsky", 29, "bob_bobsky","bob123", new DateTime(2015,11,01), 212, SubscriptionType.ThreeMonths),

            };
        }
        public User LogIn(string username, string password)
        {
            foreach(User user in Users)
            {
                if (user.UserName == username && user.Password == password)
                {
                    return user;
                    
                }
            }
            return null;
        }

        public User Register(User user)
        {
            User[] registeredUsers = Users;
            Array.Resize(ref registeredUsers, registeredUsers.Length + 1);
            registeredUsers[registeredUsers.Length - 1] = user;
            Users = registeredUsers;

            return
                Users[Users.Length - 1];
        }
        public void SeeAllUsers()
        {
            foreach(User user in Users)
            {
                Console.WriteLine(user.DisplayInfo());  
            }
        } 
    }

   

}
