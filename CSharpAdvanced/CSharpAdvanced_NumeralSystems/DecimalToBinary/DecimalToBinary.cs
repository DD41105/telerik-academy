using System;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            ulong decimalNum = ulong.Parse(Console.ReadLine());
            ulong remainder;
            string result = string.Empty;
            while (decimalNum > 0)
            {
                remainder = decimalNum % 2;
                decimalNum /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine(result);
        }
    }
}