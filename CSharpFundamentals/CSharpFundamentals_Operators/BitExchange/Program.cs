using System;

class BitExchange
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int counter = 3;

        for (int i = 24; i < 27; i++)
        {
            int mask = 1 << i;
            uint bitValue = (uint)mask & number;
            uint bit = bitValue >> i;

            int bitMask = 1 << counter;
            uint andMask = (uint)bitMask & number;
            uint bitV = andMask >> counter;

            if (bit == 0)
            {
                int maskBit = ~(1 << counter);
                number = (uint)maskBit & number;
                if (bit != bitV)
                {
                    int maskBit1 = 1 << i;
                    number = (uint)maskBit1 | number;
                }
            }
            else if (bit == 1)
            {
                int maskBit = 1 << counter;
                number = (uint)maskBit | number;
                if (bit != bitV)
                {
                    int maskBit1 = ~(1 << i);
                    number = (uint)maskBit1 & number;
                }
            }
            counter++;
        }
        Console.WriteLine(number);
    }
}