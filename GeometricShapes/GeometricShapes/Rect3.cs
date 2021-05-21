using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Rect3 : Quad   //quad is parent class and also is a constructor; quad is class being inherited
    {
        public int Area()
        {
            return Side1 * Side2;

        }            
            
        public Rect3(int s1, int s2) : base(s1, s2, s1, s2)
        { 
        }
        public override string WhatAmI()
        {
            return "Rect"; 
        }

    }
}
