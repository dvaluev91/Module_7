﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_3.Models
{
    internal class GraphicCard : ComputerPart
    {
        public override void Work()
        {
            Console.WriteLine("Видеокарта работает");
        }
    }
}
