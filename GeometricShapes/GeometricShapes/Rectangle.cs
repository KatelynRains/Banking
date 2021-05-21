using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Rectangle
    {
            public int Side1 { get; set; }
            public int Side2 { get; set; }
     

            /// establish methods
            
            public int Recp()  //for perimeter of rectangle
            {
            return Side1*2  + Side2*2;
            }
            public int Reca()  //for area of rectangle
            {
            return Side1 * Side2;
            }

    }
}
