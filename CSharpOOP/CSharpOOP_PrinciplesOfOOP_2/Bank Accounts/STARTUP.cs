using System;

namespace Bank_Accounts
{
    class STARTUP
    {
        static void Main()
        {
            // create a bank for testing purposes
            Bank bank = new Bank("DSK Bank");

            // create an inidvidual customer
            Customer firstOwner = new Customer("Georgi Georgiev", CustomerType.Individuals);
            Deposit myDeposit = new Deposit(firstOwner, 6400, 23.55m, new DateTime(2010, 05, 28));
            bank.AddAccount(myDeposit);

            // create a company customer
            Customer secondOwner = new Customer("Telerik Ltd.", CustomerType.Companies);
            Mortgage telerikLoanAccount = new Mortgage(secondOwner, 245000000, 34.88m, new DateTime(2006, 10, 20));
            bank.AddAccount(telerikLoanAccount);

            // test the Bank and Account classes' overriden ToString methods
            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllAccounts[i]);
            }

            // test the Deposit/Withdraw functionalities
            decimal withdrawAmount = 1200M;
            decimal depositAmount = 20000M;

            myDeposit.WithDraw(withdrawAmount);
            telerikLoanAccount.MakeDeposit(depositAmount);

            // print results
            Console.WriteLine("\nToday {0} withdrew {1:C} from his account and now {0} has {2:C}"
                , myDeposit.Client.Name, withdrawAmount, myDeposit.Balance);

            Console.WriteLine("\nToday {0} made a deposit {1:C} into their account and now {0} have {2:C}"
                , telerikLoanAccount.Client.Name, depositAmount, telerikLoanAccount.Balance);
        }
    }
}