using System;
using Practice5._24._2.Exceptions;
namespace Practice5._24._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var acct100 = new Account();
            acct100.Deposit(100);
            try
            { acct100.Withdraw(12000); }
            catch (InsufficientFundsException ex) { }
            catch (DivideByZeroException ex) { throw; }
            catch (Exception ex) { }

            var sv1 = new Savings();
            sv1.Deposit(2000);
            ///depositing to savings

            var cd10 = new CertificateOfDeposit(5000, 60);
            var accounts = new IBanking[] { sv1, cd10 };

            //displays balance in all accounts
            foreach (var acct in accounts)
            {
                Console.WriteLine($"Account balance is {acct.GetBalance()}");
            }
            var cd1 = new CertificateOfDeposit(Amount: 1000, Months: 12);
            //cd1.Deposit(1);
            //cd1.Withdraw(1);
            cd1.WithdrawDate = DateTime.Now.AddDays(-1); // yesterday
            var funds = cd1.Withdraw();
        }



            }
            
        }
    }
}
