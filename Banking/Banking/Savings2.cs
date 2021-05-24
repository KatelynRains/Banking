using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Savings2 : IBanking
    {  ///needed for interface to return balance and account number
        string IBanking.GetAccountNumber()
        {
            return account.AccountNumber;
        }

        decimal IBanking.GetBalance()
        {
            return account.Balance;
        }
    //creating Savings class using composition - probably easier to inherit class
    
        private Account account = new Account();
        public decimal InterestRate { get; private set; } = 0.12m; //defaults to 1% - this is the annual rate

        public decimal CalculateInterestByMonths(int NumberOfMonths)
        {
            return account.Balance * (InterestRate / 12.0m) * NumberOfMonths;

        }
        public void PayInterest(int NumberOfMonths)
        {
            var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }
           
        public bool Deposit(decimal amount)  //need to call calcs done in account class - they arent just i there like inheritance
        {
           return account.Deposit(amount); 
        }
        public bool Withdrawal(decimal amount)
        {
            return account.Withdrawal(amount);
        }
        public bool Transfer(decimal amount, Account toAccount)
        {
            return account.Transfer(amount, toAccount); 
        }

        public Savings2() { account = new Account();}
    }
}