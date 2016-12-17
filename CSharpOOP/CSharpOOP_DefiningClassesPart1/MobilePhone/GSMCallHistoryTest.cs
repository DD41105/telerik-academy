using System;

namespace MobilePhone
{
    public class GSMCallHistoryTest
    {
        public static void TestCallHistory()
        {
            GSM usersPhone = new GSM("Galaxy Note 8", "Samsung", 900, "Pesho Peshev", new Battery(BatteryType.LiIon), new Display(5.7));

            Call firstCall = new Call(usersPhone, DateTime.Now, "0886521490", 150);
            usersPhone.AddACall(firstCall);

            Call secondCall = new Call(usersPhone, DateTime.Now, "0895322775", 202);
            usersPhone.AddACall(secondCall);

            Call thirdCall = new Call(usersPhone, DateTime.Now, "0876378975", 250);
            usersPhone.AddACall(thirdCall);

            usersPhone.PrintCallHistory();
            // print total price of calls assuming the price is 0.37 lv per minute
            usersPhone.CalculateTotalPriceOfCalls(0.37);
            // test the DeleteACall method by deleting the longest call
            usersPhone.DeleteACall(thirdCall);
            // calculate again with this call removed
            Console.WriteLine("Calculating price after the longest call has been removed...");
            usersPhone.CalculateTotalPriceOfCalls(0.37);
            // clear the calls history and print it
            usersPhone.ClearCallHistory();
            usersPhone.PrintCallHistory();
        }
    }
}