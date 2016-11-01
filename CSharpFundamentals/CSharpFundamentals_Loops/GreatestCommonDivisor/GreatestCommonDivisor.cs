using System;

namespace GreatestCommonDivisor
{
    class GreatestCommonDivisor
    {
        static void Main()
        {
            string[] num = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(num[0]);
            int b = Convert.ToInt32(num[1]);

            int remainder = 0;

            while (a > 0 && b > 0)
            {
                if (a > b)
                {
                    remainder = a % b;
                    a = b;
                    b = remainder;
                }
                else
                {
                    remainder = b % a;
                    b = a;
                    a = remainder;
                }
            }
            if (a == 0)
            {
                Console.WriteLine(b);
            }
            else if (b == 0)
            {
                Console.WriteLine(a);
            }
        }
    }
}