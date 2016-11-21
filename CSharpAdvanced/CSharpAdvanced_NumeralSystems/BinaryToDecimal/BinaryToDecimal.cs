using System;
using System.Numerics;

namespace BinaryToDecimal
{
    class BinaryToDecimal
    {
        static void Main()
        {
            BigInteger binary = BigInteger.Parse(Console.ReadLine());
            BigInteger dec = 0;
            BigInteger base_value = 1;
            BigInteger remainder = 0;

            while (binary > 0)
            {
                remainder = binary % 10;
                dec = dec + remainder * base_value;
                binary = binary / 10;
                base_value = base_value * 2;
            }

            Console.WriteLine(dec);
        }
    }
}