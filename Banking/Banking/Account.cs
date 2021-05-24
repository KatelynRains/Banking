using Banking.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class Account
    {
        public string AccountNumber { get; private set; }
        public decimal Balance { get; private set; }
        public string RoutingNumber { get; set; }
        public string Description { get; set; }

        public virtual bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new  InvalidParameterException(amount);  //need to add Using since namespace is different
            }
            Balance = Balance + amount;
            return true;
        }
        public virtual bool Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidParameterException(amount);  //need to add Using since namespace is different
            }
            if(amount > Balance)
            {
                throw new InsufficientFundsException(amount, Balance);
            }
            Balance = Balance - amount;
            return true;      
        }
        public bool Transfer(decimal amount, Account toAccount)
        {
            var success = this.Withdrawal(amount);
            if (success == true)
            {
                toAccount.Deposit(amount);
                return true;
            }
            return false; 
        }
    }
}
