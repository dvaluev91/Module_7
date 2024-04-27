using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2.Models
{
    public class DerivedClass : BaseClass
    {
        private int counter;
        public override int Counter 
        {
            get
            {
                return counter;
            }
            set
            {
                if (value >= 0)
                {
                    counter = value;

                }
                else
                {
                    Console.WriteLine("Число должно быть больше 0");
                }
            } 
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("Метод класса DerivedClass");
        }
    }
}
