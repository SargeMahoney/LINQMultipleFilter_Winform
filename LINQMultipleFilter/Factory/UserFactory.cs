using LINQMultipleFilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMultipleFilter.Factory
{
    public static class UserFactory
    {


        public static List<User> CreateUsersList()
        {
            return new List<User>()
            {
                new User(){ Name = "John", Active = true, Age=50 },
                new User(){ Name = "Carl", Active = true, Age=18 },
                new User(){ Name = "Marie", Active = true, Age=60 },
                new User(){ Name = "Edward", Active = true, Age=7 },
                new User(){ Name = "Nick", Active = false, Age=33 },
                new User(){ Name = "Teo", Active = true, Age=41 },
                new User(){ Name = "Paul", Active = false, Age=81 },
                new User(){ Name = "Steven", Active = true, Age=22 },
            };
        }
    }
}
