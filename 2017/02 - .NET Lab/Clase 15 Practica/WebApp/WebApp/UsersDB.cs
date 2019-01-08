using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public static class UsersDB
    {
        public static List<String> UsersAccounts = new List<string>();

        public static void AddUser(string user)
        {
            if (!UsersAccounts.Contains(user))
                UsersAccounts.Add(user);
        }


    }
}