using System;
using System.Collections.Generic;
using System.Text;

namespace Practice5._24._2
{
    class Savings : IBanking
    {
        private Account account = new Account();  ///I think you do this step before composition
        public string AccountNumber { get { return account.AccountNumber; } set { } }
        public decimal InterestRate { get; private set; } = 0.12m;
        ///these are the properties different than the account class

        public decimal CalculateInterestByMonths(int NumberOfMonths)
        { return account.Balance * (InterestRate / 12.0m) * NumberOfMonths;
        
        }
        public void PayInterest(int NumberOfMonths)
        { var interest = CalculateInterestByMonths(NumberOfMonths);
            Deposit(interest);
        }

        public bool Deposit(decimal amount)
        { return account.Deposit(amount);
         }

        public bool Withdraw(decimal amount)
        { return account.Withdraw(amount); }
        public bool Transfer(decimal amount, Account toAccount)
        { return account.Transfer(amount, toAccount); }
        public decimal GetBalance()
        {
            return account.Balance;
        }
        public string GetAccountNumber()
        { return account.AccountNumber;
        }

        public Savings() { account = new Account(); }
    }
