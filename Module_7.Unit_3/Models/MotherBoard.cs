using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    internal class MotherBoard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Материнская плата работает");
        }
    }
}
