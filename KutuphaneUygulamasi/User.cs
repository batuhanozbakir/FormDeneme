﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutuphaneUygulamasi
{
    public class User
    {
        public string Name { get; set; }
        public Guid Id { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; } = UserType.User;
    }

    public enum UserType
    {
        None = 0,
        Admin ,
        Moderator,
        User
    }
}
