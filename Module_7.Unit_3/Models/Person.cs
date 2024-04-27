using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    abstract class Person
    {
        public string Name;
        public Person(string name)
        {
            Name = name;
        }
        public void DisplayName()
        {
            Console.WriteLine(Name);
        }
    }
}
