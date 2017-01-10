using System;

namespace Bank_Accounts
{
    public class Deposit : Account, IWithDrawable
    {
        // Constructor
        public Deposit(Customer customer, decimal balance, decimal rate, DateTime openDate)
            : base(customer, balance, rate, openDate)
        {

        }

        //A method that overrides the virtual method ClaculateInterestAmount() from the parent clas Account
        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }

        // Method comes from IWithDrawable interface
        public void WithDraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}