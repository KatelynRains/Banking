using System;

namespace ExceptionLession
{
    class Program
    {
        static void Main(string[] args)
        {
            Level1();
        }
        static void Level1() 
        {
            Level2();
        }
        static void Level2()
        {
            Level3();
        }
        static void Level3()
        {
            var n = 1;
            var d = 0;
            try
            {
                var e = n / d;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
            }
        }
    }
}
