using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_7.Unit_2._2.Models
{
    internal class IndexingClass
    {
        private int[] array;

        public IndexingClass(int[] array)
        {
            this.array = array; 
        }
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }

    }
}
