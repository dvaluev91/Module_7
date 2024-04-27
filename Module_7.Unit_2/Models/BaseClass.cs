using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2.Models
{
    public class BaseClass
    {
        public virtual int Counter { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Метод класса BaseClass");
        }
    }
}
