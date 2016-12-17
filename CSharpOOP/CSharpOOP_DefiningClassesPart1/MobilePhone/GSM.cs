using System;
using System.Text;
using System.Collections.Generic;

namespace MobilePhone
{
    public class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery phonesBattery;
        private Display phonesDisplay;
        private List<Call> callsHistory;

        public static readonly GSM IPhone4S = new GSM("iPhone 4S", "Apple", 500, "Unknown owner", new Battery(BatteryType.LiIon), new Display(3.5));

        public string Model
        {
            get
            {
                return this.model;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Not a valid model name!");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Not a valid manufacturer name!");
                }

                this.manufacturer = value;
            }
        }

        public double Price
        {
            get
            {
                return this.price;
            }
            set
            {
                    this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery PhonesBattery
        {
            get
            {
                return this.phonesBattery;
            }
            set
            {
                this.phonesBattery = value;
            }
        }

        public Display PhonesDisplay
        {
            get
            {
                return this.phonesDisplay;
            }
            set
            {
                this.phonesDisplay = value;
            }
        }

        public List<Call> CallsHistory
        {
            get
            {
                return this.callsHistory;
            }
            set
            {
                this.callsHistory = value;
            }
        }

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.CallsHistory = new List<Call>();
        }

        public GSM(string model, string manufacturer, Battery batteryInfo, Display displayInfo)
            : this(model, manufacturer)
        {
            this.PhonesBattery = phonesBattery;
            this.PhonesDisplay = phonesDisplay;
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery phonesBattery, Display phonesDisplay)
            : this(model, manufacturer)
        {
            this.PhonesBattery = phonesBattery;
            this.PhonesDisplay = phonesDisplay;
            this.Price = price;
            this.Owner = owner;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("This phone's model is: ").Append(this.model).Append("\r\n");
            sb.Append("It was produced by ").Append(this.manufacturer).Append("\r\n");
            sb.Append("It costs ").Append(this.price).Append(" and is owned by ").Append(this.owner);

            if (this.phonesBattery != null)
            {
                sb.Append("\r\n").Append(this.phonesBattery.ToString());
            }
            else
            {
                sb.Append("\r\n").Append("Currently the phone has no battery inserted.");
            }
            if (this.phonesDisplay != null)
            {
                sb.Append("\r\n").Append(this.phonesDisplay.ToString());
            }
            else
            {
                sb.Append("\r\n").Append("Currently the phone's display is not working.").Append("\r\n");
            }

            return sb.ToString();
        }

        public void AddACall(Call currentCall)
        {
            this.CallsHistory.Add(currentCall);
        }

        public void DeleteACall(Call currentCall)
        {
            this.CallsHistory.Remove(currentCall);
        }

        public void ClearCallsHistory()
        {
            this.CallsHistory.Clear();
        }

        public void PrintCallHistory()
        {
            foreach (var call in this.CallsHistory)
            {
                Console.WriteLine(call);
            }
        }

        public void ClearCallHistory()
        {
            this.CallsHistory.Clear();
        }

        public void CalculateTotalPriceOfCalls(double pricePerMinute)
        {
            double totalSum = 0;
            for (int i = 0; i < this.callsHistory.Count; i++)
            {
                totalSum += (this.CallsHistory[i].callDuration / 60) * pricePerMinute;
            }

            Console.WriteLine("Total sum is {0:F2} leva", totalSum);
        }
    }
}