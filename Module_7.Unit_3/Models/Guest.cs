using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    internal class Guest : Person
    {
        public DateTime ArrivalDates;

        public Guest(string name, DateTime arrivakDate): base(name) 
        {
            ArrivalDates = arrivakDate;
        }
    }
}
