using System;

namespace MobilePhone
{
    class GSMTest
    {
        GSM[] phonesArray = {
        new GSM("Galaxy S6 Edge", "Samsung", 879, "Unknown", new Battery(BatteryType.NiMH), new Display(5.0)),
        new GSM("iPhone 7", "Apple", 1600, "Unknown", new Battery(BatteryType.LiPo), new Display(4.7)),
        new GSM("Priv", "BlackBerry", 1400, "Unknown", new Battery(BatteryType.NiCd), new Display(4.5)),
        new GSM("X Performance", "Sony", 900, "Unknown", new Battery(BatteryType.LiIon), new Display(4.8))
        };

        public void DisplayInfoForPhones()
        {
            foreach (var phone in phonesArray)
            {
                Console.WriteLine(phone);
            }

            Console.WriteLine(GSM.IPhone4S);
        }
    }
}