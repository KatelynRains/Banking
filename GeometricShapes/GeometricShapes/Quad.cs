using System;
using System.Collections.Generic;
using System.Text;
// create a class for a quadralateral where 4 sides can be tracked
//then create a method to calculate the perimeter - everything should be an integer
namespace GeometricShapes
{
    class Quad
    {///Establish properties
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }
        public int Side4 { get; set; }

        /// establish methods
        public int QP()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

       
    }
}
