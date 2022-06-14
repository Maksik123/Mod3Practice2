using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod3Practice2.Models
{
    public class Contact
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Contact(string name, int age)
        {
            Age = age;
            Name = name;
        }
    }
}
