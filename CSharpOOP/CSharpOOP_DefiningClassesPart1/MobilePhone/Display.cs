using System;
using System.Text;

namespace MobilePhone
{
    public class Display
    {
        private double displaySize;
        private double numOfColors;

        public double DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                this.displaySize = value;
            }
        }

        public double NumOfColors
        {
            get
            {
                return this.numOfColors;
            }
            set
            {
                this.numOfColors = value;
            }
        }
        
        public Display(double displaySize, double numOfColors)
        {
            this.DisplaySize = displaySize;
            this.NumOfColors = numOfColors;
        }

        public Display(double displaySize)
        {
            this.DisplaySize = displaySize;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Display size: ").Append(this.displaySize).Append("\r\n");
            return builder.ToString();
        }
    }
}
