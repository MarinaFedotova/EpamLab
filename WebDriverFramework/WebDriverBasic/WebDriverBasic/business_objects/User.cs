﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WebDriverBasic.business_objects
{
    class User
    {
        public User(string userName, string userPassword)
        {
            UserName = userName;
            UserPassword = userPassword;
        }

        public string UserName { get; set; }
        public string UserPassword { get; set; }
    }
}
