using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{ /// can consolidate code is multiple classes are using ismilar calcs
    //some people build a class simply to use in other classes


    class rect2
    {
        public Quad quad { get; set; }
        public int Perimeter()
        {
            return quad.Perimeter();
        }

        public rect2 (int s1, int s2)
        { quad = new Quad(s1, s2, s1, s2); }


    }
}
