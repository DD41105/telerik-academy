using System;

namespace MobilePhone
{
    public class Startup
    {
        static void Main()
        {
            // testing the overriden ToString method in the GSM class
            GSM testPhone1 = new GSM("iPhone 6S Plus", "Apple");
            Console.WriteLine(testPhone1.ToString());

            // testing the GSMTest class and its DisplayInfoForPhones method
            GSMTest printTestPhones = new GSMTest();
            printTestPhones.DisplayInfoForPhones();

            // testing the display info method of the same GSMTest class but for the iPhone4S instance
            printTestPhones.DisplayInfoForIphone4s();

            // testing GSMCallHistoryTest class
            GSMCallHistoryTest.TestCallHistory();
        }
    }
}