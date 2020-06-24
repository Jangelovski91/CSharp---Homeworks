using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise01
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public abstract void PrintUser();

    }
}
