using System;
using System.Numerics;

namespace CalculateAgain
{
    class CaluclateAgain
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong K = ulong.Parse(Console.ReadLine());
            BigInteger factorialN = 1;
            BigInteger factorialK = 1;

            for(ulong i = 1; i <= N; i++)
            {
                factorialN = factorialN * i;
                if (i <= K)
                {
                    factorialK = factorialK * i;
                }
            }

            Console.WriteLine(factorialN / factorialK);
        }
    }
}