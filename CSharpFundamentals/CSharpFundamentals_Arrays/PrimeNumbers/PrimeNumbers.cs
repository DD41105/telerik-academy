using System;

namespace PrimeNumbers
{ 
    // TODO: FIX! Not working!
    class PrimeNumbers
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            bool[] primes = new bool[N]; 

            // Find all prime numbers to N
            for (int i = 2; i < Math.Sqrt(primes.Length); i++)
            {
                // Skip the ones which are not prime
                if (primes[i] == false)
                {
                    for (int j = i * i; j < primes.Length; j += i)
                        primes[j] = true;
                }
            }

            // Print max prime number
            for (int i = primes.Length - 1; i > 2; i--)
            {
                if (primes[i])
                {
                    Console.WriteLine(i);
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}