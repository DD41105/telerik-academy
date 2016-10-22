using System;

namespace _3rdBit
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            int mask = 1 << 3;
            int andMask = N & mask;
            int bit3 = andMask >> 3;
            Console.WriteLine(bit3);
        }
    }
}