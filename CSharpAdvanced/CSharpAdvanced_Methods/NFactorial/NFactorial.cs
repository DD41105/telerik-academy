using System;
using System.Numerics;

namespace NFactorial
{
    class NFactorial
    {
        static BigInteger Factorial(int N)
        {
            BigInteger result = 1;

            for (int i = 1; i <= N; i++)
            {
                result *= i;
            }

            return result;
        }
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(N));
        }
    }
}