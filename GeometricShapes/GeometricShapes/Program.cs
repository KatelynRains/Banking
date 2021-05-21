using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            //cals for quad
            var quad1 = new Quad();
            quad1.Side1 = 4;
            quad1.Side2 = 2;
            quad1.Side3 = 1;
            quad1.Side4 = 2;

            Console.WriteLine($"Perimeter of quad is {quad1.QP()}");

            //calcs for rectangle
            var rec1 = new Rectangle();
            rec1.Side1 = 4;
            rec1.Side2 = 2;
            Console.WriteLine($"Perimeter of rectangle is {rec1.Recp()} and the area is {rec1.Reca()}");

            //calcs for square
            var sq1 = new Square();
            sq1.Side1 = 1;
        
            Console.WriteLine($"Perimeter of the square is {sq1.sqp()} and area of the square is {sq1.sqa()}");
        }



    }
    
}
