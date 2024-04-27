using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    internal class Dog : FourLeggedAnimal
    {
        private string name;

        public override string Name
        {
            get { return name; }
            set { name = value; }
        }

        public override void Describe()
        {
            Console.WriteLine("Это животное - собака");
        }
    }
}
