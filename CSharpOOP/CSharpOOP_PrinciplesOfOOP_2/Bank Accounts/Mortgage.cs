using System;

namespace Bank_Accounts
{
    public class Mortgage : Account
    {
        public Mortgage(Customer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        // Method that overrides the virtual method from class Account
        public override decimal CalculateInterestAmount()
        {
            if (this.Client.Type == CustomerType.Individuals && this.Months < 6)
            {
                return 0;
            }

            if (this.Client.Type == CustomerType.Companies && this.Months <= 12)
            {
                return (base.CalculateInterestAmount() / 2);
            }

            return base.CalculateInterestAmount();
        }
    }
}