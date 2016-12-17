using System;

namespace MobilePhone
{
    public class GSMTest
    {
        GSM[] phonesArray = {
        new GSM("Galaxy S6 Edge", "Samsung", 879, "Pesho", new Battery(BatteryType.NiMH), new Display(5.0)),
        new GSM("iPhone 7", "Apple", 1600, "Gosho", new Battery(BatteryType.LiPo), new Display(4.7)),
        new GSM("Priv", "BlackBerry", 1400, "Dragan", new Battery(BatteryType.NiCd), new Display(4.5)),
        new GSM("X Performance", "Sony", 900, "Kiro", new Battery(BatteryType.LiIon), new Display(4.8))
        };

        public void DisplayInfoForPhones()
        {
            foreach (var phone in phonesArray)
            {
                Console.WriteLine(phone);
            }
        }

        public void DisplayInfoForIphone4s()
        {
            Console.WriteLine(GSM.IPhone4S);
        }
    }
}