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
            return 2*(Side1 + Side2);
            }    

            public int Reca()  //for area of rectangle
            {
            return Side1 * Side2;
            }


        // using constructors
             public Rectangle(int s1, int s2)
             {
            Side1 = s1;
            Side2 = s2;
             }


    }       
}
