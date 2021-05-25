using LibraryLesson;
using System;

namespace TestLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            var OnePlusTwo = MathLib.Add(1, 2);
            var OneLessTwo = MathLib.Subtract(1, 2);
            var OneTimesTwo = MathLib.Multiply(1, 2);
            var OneDivideTwo = MathLib.Divide(1, 2);
            var OneModTwo = MathLib.Modulo(5, 3);
            var mod = 5 % 3;
           
            Console.WriteLine($"{OneModTwo} {mod}");
        }
       

       
    }
}
