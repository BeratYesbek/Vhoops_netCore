﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.Concrete
{
    public class Person : IEntity
    {
        public Person(string firstName, string lastName, string email, string password , string userID, string userUUID)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            UserID = userID;
            UserUUID = userUUID;
            Password = password;
        }

        public string FirstName { get; }

        public string LastName { get; }

        public string Email { get; }

        public string Password { get; }

        public string UserID { get; }

        public string UserUUID { get; }

    }
}