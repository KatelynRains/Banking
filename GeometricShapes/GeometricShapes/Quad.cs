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

        /// establish methods - without using constructors
        public int Perimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }

        public virtual string WhatAmI()
        { return "Quad"; }
        //public Quad() { }

        //if you wanted to do a constructor
        public Quad(int s1, int s2, int s3, int s4)
        {
            Side1 = s1;
            Side2 = s2;
            Side3 = s3;
            Side4 = s4; 

        }
       
    }
}
