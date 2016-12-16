using System;
using System.Text;

namespace MobilePhone
{
    class GSM
    {
        private string model;
        private string manufacturer;
        private double price;
        private string owner;
        private Battery phonesBattery;
        private Display phonesDisplay;

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

        public GSM(string model, string manufacturer)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
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
                sb.Append("\r\n").Append("Currently the phone's display is not working.");
            }

            return sb.ToString();
        }
    }
}
