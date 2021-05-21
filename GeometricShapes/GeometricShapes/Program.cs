using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)

             


        { var rect3 = new Rect3(4,7);
            Console.WriteLine($"Perimeter is {rect3.Perimeter()}");
            var sqr3 = new Sqr3(5);
            Console.WriteLine($"Perimeter is {sqr3.Perimeter()} and Area is {sqr3.Area()}");


            var x = 0;

            //cals for quad - this is the method without constructors
            //var quad1 = new Quad();
            //quad1.Side1 = 4;
            //quad1.Side2 = 2;
            //quad1.Side3 = 1;
            //quad1.Side4 = 2;

            //Console.WriteLine($"Perimeter of quad is {quad1.QP()}");
                     
                //calcs for quad using constructos
                var quad1 = new Quad(4, 3, 1, 2);
               Console.WriteLine($"Perimeter of quad is {quad1.Perimeter()}");
            var rect2 = new rect2(4, 7);
            Console.WriteLine($"Perimeter is ");

            //calcs for rectangle
            var rec1 = new Rectangle(1,2);
      
            Console.WriteLine($"Perimeter of rectangle is {rec1.Recp()} and the area is {rec1.Reca()}");

            //calcs for square
            var sq1 = new Square();
            sq1.Side1 = 1;
        
            Console.WriteLine($"Perimeter of the square is {sq1.sqp()} and area of the square is {sq1.sqa()}");
        }



    }
    
}
