﻿using System;
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

        public bool Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"Amount must be GT zero ");
                return false;
            }
            Balance = Balance + amount;
            return true;
        }
        public bool Withdrawal(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine($"AMount must be GT zero ");

                return false;
            }
            if(amount > Balance)
            {   Console.WriteLine($"Insufficient funds ");
                return false;
            }
            Balance = Balance - amount;
            return true;      
        }
        public bool Transfer(decimal amount, Account toAccount)
        { 
        }
    }
}