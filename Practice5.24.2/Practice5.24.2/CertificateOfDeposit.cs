using System;
using System.Collections.Generic;
using System.Text;

namespace Practice5._24._2
{
    class CertificateOfDeposit

        //re-doing this as composition
    {
        private Account account = new Account();
        //adding properties that are different than account class
        public DateTime DepositDate { get; set; } = DateTime.Now;
        //sets current day as deposit day
        public DateTime WithdrawDate { get; set; }
        public bool Withdraw()
        { if (DateTime.Now < WithdrawDate)
            {   Console.WriteLine($"Cannot withdraw until Withdraw date");
                return false;
            }
            return account.Withdraw(account.Balance);
        }
        public decimal GetBalance()
        {
            return account.Balance;
        }
        public string GetAccountNumber()
        {
            return account.AccountNumber; 
        }
        /// creating constructor
        public CertificateOfDeposit(decimal Amount, int Months) {
            var success = account.Deposit(Amount);
            //check success to see if deposit worked
            var interestRate = 0.0m;
            switch (Months) {
                case 12: interestRate = 0.01m; break;
                case 24: interestRate = 0.02m; break;
                case 36: interestRate = 0.03m; break;
                case 48: interestRate = 0.04m; break;
                case 60: interestRate = 0.05m; break;
                default:
                    break; 
            }
            var interest = account.Balance * (interestRate / 12) * Months;
            success = account.Deposit(interest);
            WithdrawDate = DepositDate.AddMonths(Months);
        
        }
        
        
    }


    
}