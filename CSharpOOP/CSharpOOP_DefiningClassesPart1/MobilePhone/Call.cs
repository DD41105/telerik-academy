using System;
using System.Text;

namespace MobilePhone
{
    public class Call
    {
        public GSM phoneUsed { get; set; }
        public DateTime timeOfCall { get; set; }
        public string dialedNum { get; set; }
        public int callDuration { get; set; }

        public Call(GSM phoneUsed, DateTime timeOfCall, string dialedNum, int callDuration)
        {
            this.phoneUsed = phoneUsed;
            this.timeOfCall = timeOfCall;
            this.dialedNum = dialedNum;
            this.callDuration = callDuration;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Phone used: ").Append(this.phoneUsed.Manufacturer).Append(" ").Append(this.phoneUsed.Model).Append("\r\n");
            builder.Append("Date and time of call: ").Append(this.timeOfCall).Append("\r\n");
            builder.Append("Number called: ").Append(this.dialedNum).Append("\r\n");
            builder.Append("Call duration: ").Append(this.callDuration).Append("\r\n");

            return builder.ToString();
        }
    }
}