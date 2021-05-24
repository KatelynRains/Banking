using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CertificateOfDeposit : Account
    {
        public DateTime DepositDate { get; private set; } = DateTime.Now;
        public DateTime WithdrawlDate { get; set; }
        public decimal InterestRate { get; set; }
        public int Months { get; set; }

       
        public override bool Deposit(decimal amount)
        {
           Console.WriteLine("Cannot call Deposit() on a CD");
           return false; 
         }
         
        
        public override bool Withdrawal(decimal amount)
       
        {
            Console.WriteLine($"Call Withdrawal() after Withdraw Date to receive all funds");
            return false;
        }
        public bool Withdrawal()
        {
            if (DateTime.Now < WithdrawlDate)
            {
                Console.WriteLine($"Cannot withdraw funds from CD till {WithdrawlDate.ToString("MM/dd/yyyy")}");
                return false;
            }
            return base.Withdrawal(Balance);
        }
        private void CalcAndPayInterestOnDeposit()
        {
            var interest = Balance * (InterestRate / 12) * Months;
            base.Deposit(decimal.Round(interest, 2));
        
        }

        private void SetDurationAndRate(int months)
        {
            switch (months)
            {
                case 12: WithdrawlDate = DepositDate.AddYears(1); InterestRate = 0.01m; break;
                case 24: WithdrawlDate = DepositDate.AddYears(2); InterestRate = 0.02m; break;
                case 36: WithdrawlDate = DepositDate.AddYears(3); InterestRate = 0.03m; break;
                case 48: WithdrawlDate = DepositDate.AddYears(4); InterestRate = 0.04m; break;
                case 60: WithdrawlDate = DepositDate.AddYears(5); InterestRate = 0.05m; break;
                default:
                    break;
             }
        }
        ///only constructor
        public CertificateOfDeposit(decimal Amount, int Months)
        { this.Months = Months;
         SetDurationAndRate(Months);
        var success = base.Deposit(Amount);
         CalcAndPayInterestOnDeposit();
        }


    }
}
