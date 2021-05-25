using System;
using System.Collections.Generic;
using System.Text;
using Practice5._24._2.Exceptions;
namespace Practice5._24._2
{
    class Account
    { //establishing properties
        public string AccountNumber { get; set; }
        public decimal Balance { get; set; }
        public string RoutingNumber { get; set; }
        public string Description { get; set; }

        //methods

        public virtual bool Deposit(decimal amount)
        { if (amount <= 0)
            {
                throw new InvalidParameterException(amount);             
            }
            Balance = Balance + amount;
            return true; 
        }
        /// if amount specified in program is less than 0 exception is thrown and cannot be ignored
        /// otherwise amount is added to balance
        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new InvalidParameterException(amount);
            }
            if (amount > Balance)
            {
                throw new InsufficientFundsException(amount, Balance);
            }
            Balance = Balance - amount;
            return true;
        }
        //if amount speficied in program is <= 0 then exception is thrown if the amount is more than the balance ISF exception is throw
        //neither exception can be ignored; otherwise the amount is subtracted from the balance
        //
        public bool Transfer(decimal amount, Account toAccount)
            {
                var success = this.Withdraw(amount);
                if (success == true) 
                {   toAccount.Deposit(amount);
                    return true;        
                }
                return false;                
         //if the withdraw (defined as variable to test) was successful (not less than 0 or greater than balance), then
         //deposit amount to speficied account in program, otherwise 
        
        }
    }
}
