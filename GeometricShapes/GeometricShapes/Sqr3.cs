using System;
using System.Collections.Generic;
using System.Text;

namespace GeometricShapes
{
    class Sqr3 : Rect3 
    {
        public override string WhatAmI()
        {
            return "Sqre";
        }


        public Sqr3(int s) : base(s, s) { }


    }
}
