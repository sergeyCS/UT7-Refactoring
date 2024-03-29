﻿using _7_Refactoring.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _7_Refactoring.Factories
{
    public class UserFactory
    {
        public static User Create(object[] data)
        {
            Precondition.Requires(data.Length >= 4);

            int userId = (int)data[0];
            string email = (string)data[1];
            UserType type = (UserType)data[2];
            bool isEmailConfirmed = (bool)data[3];

            return new User(userId, email, type, isEmailConfirmed);
        }
    }
}
