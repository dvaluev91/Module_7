using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    internal class Employee : Person
    {
        public bool IsOnShift;
        public Employee(string name, bool isOnShift) : base(name)
        {
            IsOnShift = isOnShift;
        }
            
    }
}
