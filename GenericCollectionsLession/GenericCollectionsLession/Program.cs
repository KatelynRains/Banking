using System;
using System.Collections.Generic; //need to add namespace when doing generic lists

namespace GenericCollectionsLession
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var ints = new List<int>();


            for (var idx = 0; idx < 30; idx++)
            {
                var score = rnd.Next(0, 31);
                ints.Add(score);
            }

            var total = 0;
            foreach (var i in ints) 
            {
              total = total + i;
            }
            Console.WriteLine($"Total is {total}");
            ints.ToList().foreach(Console.WriteLine);
            
        }        
    }
}
