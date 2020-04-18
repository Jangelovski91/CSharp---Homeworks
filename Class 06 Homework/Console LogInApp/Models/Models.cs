using System;
using System.Collections.Generic;
using System.Text;

namespace Console_LogInApp.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string[] Messages { get; set; }

        public User(int id, string username, string password, string[] messages)
        {
            ID = id;
            Username = username;
            Password = password;
            Messages = messages;
        }

        public User() { }

    }
}
