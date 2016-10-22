using System;

namespace NByte
{
    class NByte
    {
        static void Main()
        {
            long p = long.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());

            if (n < 55 && p >= 0 && p <= Math.Pow(2, 55))
            {
                long mask = 1 << n;
                long andMask = p & mask;
                long bit = andMask >> n;
                Console.WriteLine(bit);
            }
        }
    }
}