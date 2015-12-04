using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMPE1700Lab03
{
    public class Vector
    {
        public int[] Values { get; set; } //Array of contents
        public int Length { get; set; } //Number of valid entries at beginning

        public Vector()
        {
            Values = null;
            Length = 0;
        }
    }
}
