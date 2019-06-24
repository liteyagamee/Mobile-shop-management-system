﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileShopManagementSystem.Model
{
    public class User
    {
        public int UserId
        { get; set; }
        public string Firstname
        { get; set; }
        public string Lastname
        { get; set; }
        public string Phone
        { get; set; }
        public string Email
        { get; set; }
        public string Gender
        { get; set; }
        public string Username
        { get; set; }
        public string Password
        { get; set; }
    }
}
