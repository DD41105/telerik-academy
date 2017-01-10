using System;
using System.Collections.Generic;

namespace Range_Exceptions
{
    public class InvalidRangeException<T> : ApplicationException
    {
        // fields and properties
        private T start;
        private T end;

        public T End
        {
            get { return end; }
            set { end = value; }
        }


        public T Start
        {
            get { return start; }
            set { start = value; }
        }

        // Constructor
        public InvalidRangeException(T start, T end)
        {
            this.start = start;
            this.end = end;
        }

        // Override the message
        public override string Message
        {
            get
            {
                return string.Format("The {0} is out of the allowed range [{1} - {2}]",
                    typeof(T).Name, this.Start, this.End);
            }
        }
    }
}