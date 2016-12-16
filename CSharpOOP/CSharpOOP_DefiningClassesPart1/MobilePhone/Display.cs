using System;

namespace MobilePhone
{
    class Display
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
    }
}
