using System;
using System.Numerics;

namespace Calculate3
{
    class Caluclate3
    {
        static void Main()
        {
            ulong N = ulong.Parse(Console.ReadLine());
            ulong K = ulong.Parse(Console.ReadLine());
            ulong L = N - K;

            BigInteger factorialN = 1;
            BigInteger factorialK = 1;
            BigInteger factorialL = 1;

            for (ulong i = 1; i <= L; i++)
            {
                factorialL = factorialL * i;
            }

            for (ulong i = 1; i <= N; i++)
            {
                factorialN = factorialN * i;
                if (i <= K)
                {
                    factorialK = factorialK * i;
                }
            }

            Console.WriteLine(factorialN / (factorialK * factorialL));
        }
    }
}