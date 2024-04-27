using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2._2.Models
{
    internal class Vector
    {
        public int X;
        public int Y;

        public Vector Add(Vector second)
        {
            return new Vector
            {
                X = this.X + second.X,
                Y = this.Y + second.Y
            };
        }
        public static Vector operator +(Vector left, Vector right) 
        {
            return new Vector
            {
                X = left.X + right.X,
                Y = left.Y + right.Y
            };
        }
        public static Vector operator +(Vector a)
        {
            return new Vector
            {
                X = a.X,
                Y = a.Y
            };
        }
        public static Vector operator +(Vector a, (int X, int Y) b)
        {
            return new Vector
            {
                X = a.X + b.X,
                Y = a.Y + b.Y
            };
        }
    }
}
