using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Exceptions
{
    public class InvalidParameterException : Exception
    {
        public decimal Amount { get; set; }
        public InvalidParameterException(decimal Amount) : base() 
        { this.Amount = Amount; }



        public InvalidParameterException() : base() { } //default

        public InvalidParameterException(string Message) : base(Message) { }  //constructor with 1 parametere string

        public InvalidParameterException(string Message, Exception InnerException) : base(Message, InnerException) { }
    } 
}

