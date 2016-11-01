using System;
using System.Numerics;

namespace CatalanNumbers
{
    class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int n1 = 1 + n;
            int n2 = 2 * n;
            BigInteger nFact = 1;
            BigInteger n1Fact = 1;
            BigInteger n2Fact = 1;

            for (int i = 1; i <= n2; i++)
            {
                n2Fact *= i;
                if (i <= n + 1)
                {
                    n1Fact *= i;
                }
                if (i <= n)
                {
                    nFact *= i;
                }
            }
            Console.WriteLine(n2Fact / (n1Fact * nFact));
        }
    }
}