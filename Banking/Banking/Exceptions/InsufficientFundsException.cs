using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }

        public InsufficientFundsException(decimal Amount, decimal Balance) : base() 
        
        {this.Amount = Amount; 
         this.Balance = Balance;}

        public InsufficientFundsException() : base() { } //default

        public InsufficientFundsException(string Message) : base(Message) { }  //constructor with 1 parameter string

        public InsufficientFundsException(string Message, Exception InnerException) : base(Message, InnerException) { }  //constructor with string and exception
    }
}
