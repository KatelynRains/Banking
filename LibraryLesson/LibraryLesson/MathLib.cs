using System;

namespace LibraryLesson
{
    public class MathLib
    {
        public static int Add(int a, int b)
        { return a + b; }
        public static int Subtract(int a, int b)
        { return a - b; }
        public static int Multiply(int a, int b)
        { return a * b; }
        public static int Divide(int a, int b)
        { return a / b; }
        public static int Modulo(int a, int b)
        {
            return Subtract(a, (Multiply(Divide(a, b), b)));


        }
    }
}
