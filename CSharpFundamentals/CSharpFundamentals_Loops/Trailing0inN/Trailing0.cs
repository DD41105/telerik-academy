using System;
using System.Numerics;

namespace Trailing0inN
{
    class Trailing0
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int addFactor = 0;
            int divide = 0;
            int counter = 1;

            while (true)
            {
                divide = (int)Math.Pow(5, counter);
                addFactor += N / divide;
                if ((N / divide) < 1)
                {
                    break;
                }
                counter++;
            }
            Console.WriteLine(addFactor);
        }
    }
}