using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace FoodAPI.DAL.Entities
{
    public class User:IdentityUser
    {
        
    }

      public static class UserRoles 
    {  
        public const string Admin = "Admin";  
        public const string User = "User";  
    }
}