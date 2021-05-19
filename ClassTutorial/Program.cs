using System;

namespace ClassTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var tqlmath = new TQLMath();
            tqlmath.A = 21;
            tqlmath.B = 30;
            var Diff = tqlmath.Diff();
            Console.WriteLine($"Diff of {tqlmath.A} and {tqlmath.B} is {Diff}");
        }
    }
}
