﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string VerifyPassword { get; set; }

        public User (string username, string email, string password, string verifypassword)
        {
            Username = username;
            Email = email;
            Password = password;
            VerifyPassword = verifypassword;
        }

        public User ()
        {

        }



        //public string verify { get; set; }





    }
}
