using System;

namespace PrimeCheck
{
    class PrimeCheck
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            bool isPrime = true;
            if (N <= 100)
            {
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (N == 1 || N < 1)
                {
                    isPrime = false;
                }
                Console.WriteLine(isPrime.ToString().ToLower());
            }
        }
    }
}
