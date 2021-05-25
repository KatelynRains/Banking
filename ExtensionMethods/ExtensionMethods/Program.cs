using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var abc = "abc'";
            abc.ToUpper().ToConsole();
        }
    }
}
