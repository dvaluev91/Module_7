using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2._2.Models
{
    public class Obj
    {
        public int Value;

        public static Obj operator + (Obj a, Obj b)
        {
            return new Obj 
            {
                Value = a.Value + b.Value
            };
        }
        public static Obj operator -(Obj a, Obj b)
        {
            return new Obj 
            { 
                Value = a.Value - b.Value 
            };
        }
    }
}
