using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2.Models
{
    public class President : CivilServant
    {
		private double age;

		public override double Age
		{
			get { return age; }
			set 
			{
                if (value < 35)
                {
                    Console.WriteLine("Для работы президентом, гражданин должен быть не младше 35 лет");
                }
				else 
				{
                    age = value;
                    Console.WriteLine("Вы президент");
                }
			}
		}

	}
}
