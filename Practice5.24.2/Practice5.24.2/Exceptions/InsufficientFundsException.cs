using System;
using System.Collections.Generic;
using System.Text;

namespace Practice5._24._2.Exceptions
{
    public class InsufficientFundsException : Exception
    {
        public decimal Amount { get; set; }
        public decimal Balance { get; set; }
        //constructor
        public InsufficientFundsException(decimal Amount, decimal Balance) : base()
        {
            this.Amount = Amount;
            this.Balance = Balance;
        }


        public InsufficientFundsException() : base() { }
        public InsufficientFundsException(string Message) : base(Message) { }
        public InsufficientFundsException(string Message, Exception InnerException) : base(Message, InnerException) {}


    }
}
