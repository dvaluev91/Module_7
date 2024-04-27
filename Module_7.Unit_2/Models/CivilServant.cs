using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2.Models
{
    public class CivilServant : Citizen
    {
        private double age;
        public override double Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Для работы госслужащим, гражданин должен быть не младше 18 лет");
                }
                else
                {
                    age = value;
                }
            }
        }
    }
}
