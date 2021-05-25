using System;
using System.Collections.Generic;
using System.Text;

namespace Practice5._24._2.Exceptions
{
    public class InvalidParameterException : Exception
    {//establish parameters
        public decimal Amount { get; set; }

        //make constructor
        public InvalidParameterException(decimal Amount) : base() 
        {
            this.Amount = Amount; 
        
        }


        //default exceptions

        public InvalidParameterException() : base() { }
        public InvalidParameterException(string Message) : base(Message) { }
        public InvalidParameterException(string Message, Exception InnerException) : base(Message, InnerException) { }


    }
}
