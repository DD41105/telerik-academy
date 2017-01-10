using System;

namespace Bank_Accounts
{
    public class Loan : Account
    {
        // Constructor that invokes the base constructor
        public Loan(Customer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        // Method that overrides the vitrual method in clas Account - ClaculateInteretAmount
        public override decimal CalculateInterestAmount()
        {
            if (this.Client.Type == CustomerType.Individuals && this.Months < 3)
            {
                return 0;
            }

            if (this.Client.Type == CustomerType.Companies && this.Months < 2)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }
    }
}