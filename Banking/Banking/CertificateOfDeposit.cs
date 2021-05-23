using System;
using System.Collections.Generic;
using System.Text;

namespace Banking
{
    class CertificateOfDeposit : Account
    {
        public DateTime DepositDate { get; set; }
        public DateTime WithdrawlDate { get; set; }
        public decimal InterestRate { get; set; }
        public int CDDuration { get; set; }

        public override bool Withdrawal(decimal amount)
        {
            if (DateTime.Now < WithdrawlDate)
            {
                Console.WriteLine($"Balance not available for withdrawal until {WithdrawlDate}");
                return false;
            }

            var interest = Balance * (InterestRate / 12.0m) * CDDuration;
            base.Deposit(interest);
            return base.Withdrawal(amount);
        }
        public override bool Deposit(decimal amount)
        {
            if (Balance > 0) 
            {
                Console.WriteLine("Cannot make additional deposits");
                return false; 
            }
            DepositDate = DateTime.Now;
            WithdrawlDate = DepositDate.AddMonths(CDDuration);
            return base.Deposit(amount);
         }
        public CertificateOfDeposit(int CDDuration)
        {
            this.CDDuration = CDDuration;
            switch (this.CDDuration)
            {
                case 12: InterestRate = 0.01m; break;
                case 24: InterestRate = 0.02m; break;
                case 36: InterestRate = 0.03m; break;
                case 48: InterestRate = 0.04m; break;
                case 60: InterestRate = 0.05m; break;
             }
        }

    }
}
