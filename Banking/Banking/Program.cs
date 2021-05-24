using Banking.Exceptions;
using System;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {
            var act100 = new Account();
            act100.Deposit(-100);
            try
            {
                act100.Withdrawal(12000);
            }
            catch (InsufficientFundsException ex) { }

            catch (DivideByZeroException ex) { throw; }

            catch (Exception ex) { }  //do this one last always since first exception that is true is thrown

            var sv1 = new Savings2();
            sv1.Deposit(2000);
            var cd10 = new CertificateOfDeposit(5000, 60);
            var accounts = new IBanking[] { sv1, cd10 };
            foreach(var acct in accounts)
            {
                Console.WriteLine($"Account balance is {acct.GetBalance()}"); //need to add composition method for CD for this to work
            }
            
            
            
            
            
            
            var sav1 = new Savings();
            sav1.Deposit(1000);
            sav1.PayInterest(3);


            var acct1 = new Account();
            acct1.Deposit(500);
            acct1.Withdrawal(200);
            acct1.Withdrawal(600);
            acct1.Deposit(-400);
            Console.WriteLine($"Balance is {acct1.Balance}");

            var acct2 = new Account();

            acct1.Transfer(1000, acct2);
            Console.WriteLine($"Balance is {acct1.Balance}");
            Console.WriteLine($"Balance is {acct2.Balance}");

            var cd1 = new CertificateOfDeposit(Amount:1000, Months: 12);
            cd1.Deposit(1);
            cd1.Withdrawal(1);
            cd1.WithdrawlDate = DateTime.Now.AddDays(-1); //yesterday
            var funds = cd1.Withdrawal(); //no parameters sine we will withdraw everything in acocunt
            
         }
    }
}
