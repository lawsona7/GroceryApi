using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroceryDataAccess;

namespace GroceryApi
{
    public class CompanySecurity
    {
        public static bool Login(string username, string password)
        {
            using(GroceryDBEntities entities = new GroceryDBEntities())
            {
                return entities.Users.Any(user => user.Username.Equals(username, StringComparison.OrdinalIgnoreCase) 
                && user.Password == password);
            }
        }
    }
}