using System;
using System.Numerics;

namespace HexadecimalToDecimal
{
    class HexToDec
    {
        static void Main()
        {
            string input = Console.ReadLine();
            BigInteger result = ConvertHexToDec(input);
            Console.WriteLine(result);
        }

        static BigInteger ConvertHexToDec(string hex)
        {
            BigInteger dec = 0;
            char[] arr = hex.ToCharArray();
            Array.Reverse(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                switch (arr[i])
                {
                    case 'A':
                        dec += 10 * (BigInteger)Math.Pow(16, i);
                        break;
                    case 'B':
                        dec += 11 * (BigInteger)Math.Pow(16, i);
                        break;
                    case 'C':
                        dec += 12 * (BigInteger)Math.Pow(16, i);
                        break;
                    case 'D':
                        dec += 13 * (BigInteger)Math.Pow(16, i);
                        break;
                    case 'E':
                        dec += 14 * (BigInteger)Math.Pow(16, i);
                        break;
                    case 'F':
                        dec += 15 * (BigInteger)Math.Pow(16, i);
                        break;
                    default:
                        dec += int.Parse(arr[i].ToString()) * (BigInteger)Math.Pow(16, i);
                        break;
                }
            }
            return dec;
        }
    }
}