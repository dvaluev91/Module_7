using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_1.Models
{
    public class Car
    {
        public double Fuel;
        public int Mileage;

        public Car()
        {
            Fuel = 50;
            Mileage = 0;
        }
        public void Move()
        {
            Mileage++;
            Fuel -= 0.5;
        }
        public void FillTheCar()
        {
            Fuel = 50;
        }
    }
}
