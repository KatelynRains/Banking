using System;

namespace CustomerClass
{
    class Program
    {
        static void Main(string[] args)
        {
            var cust1 = new Customer("TQL","Cincinnati","OH");
            cust1.AddSales(1000);
            cust1.AddSales(4000);


            Console.WriteLine($"Customer {cust1.Name} sales is {cust1.Sales}");
        
                    
         }
    }
        
}


