using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2.Models
{
    public class Citizen
    {
        public virtual double Age { get; set; }
        public void SayYourAge()
        {
            Console.WriteLine("Мне {0} лет", Age);
        }
    }
}
