using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQMultipleFilter.Models
{
    public class User
    {
        public string Name { get; set; } 
        public bool Active { get; set; }
        public int Age { get; set; }


        public User()
        {
            Name = string.Empty;           
            Active = false;
            Age = 0;
        }
    }
}
