using System;
using System.Text;

namespace MobilePhone
{
    public class Battery
    {
        private string model;
        private double hoursIdle;
        private double hoursTalk;
        private BatteryType batteryType;

        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }

        public double HoursIdle
        {
            get
            {
                return this.hoursIdle;
            }
            set
            {
                this.hoursIdle = value;
            }
        }

        public double HoursTalk
        {
            get
            {
                return this.hoursTalk;
            }
            set
            {
                this.hoursTalk = value;
            }
        }

        public BatteryType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        public Battery(string model, double hoursIdle, double hoursTalk, BatteryType BatteryType)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle, double hoursTalk)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
        }

        public Battery(BatteryType BatteryType)
        {
            this.BatteryType = batteryType;
        }

        public Battery(string model, double hoursIdle)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Battery type: ").Append(this.batteryType);
            return builder.ToString();
        }
    }
}
