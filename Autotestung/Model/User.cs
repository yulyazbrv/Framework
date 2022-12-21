﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestung.Model
{
    internal class User
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public override string ToString()
        {
            return "User: " + Login + " " + Password;
        }
    }
}
