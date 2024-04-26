using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_1.Models
{
    public enum FuelType
    {
        Gas = 0,
        Electricity
    }
    public class HybridCar : Car
    {
        public FuelType FuelType;
        public void ChangeFuelType(FuelType type)
        {
            FuelType = type;
        }
    }
}
