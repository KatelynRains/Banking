using System;
using System.Collections.Generic;
//need to add namespace when doing generic lists
namespace MorningPractice5._25
{
    class Program
    {
        static void Main(string[] args)
        { //creating random numbers and creating list
            Random rnd = new Random();
            var ints = new List<int>();
            //adding 30 ints to list
            for (var idx = 0; idx < 30; idx++)
            {
                var score = rnd.Next(0, 30);
                ints.Add(score);
            }
            ///total the scores
            var total = 0;
            foreach(var i in ints)
            {
                total = total + i;
            }
            Console.WriteLine($"The total is {total}");



        }
    }
}
