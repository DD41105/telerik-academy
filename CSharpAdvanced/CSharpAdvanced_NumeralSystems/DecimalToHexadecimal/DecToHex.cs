using System;
using System.Numerics;
using System.Collections.Generic;

class DecimalToHexadecimal
{
    static void Main()
    {
        BigInteger decNumber = BigInteger.Parse(Console.ReadLine());
        List<string> hex = FromDecimalToHexadecimal(decNumber);

        foreach (var item in hex)
        {
            Console.Write(item);
        }
    }

    static List<string> FromDecimalToHexadecimal(BigInteger decNumber)
    {
        List<string> hex = new List<string>();
        BigInteger remainder = 0;
        while (decNumber > 0)
        {
            if (decNumber % 16 == 0)
            {
                hex.Add("0");
            }
            if (decNumber % 16 != 0)
            {
                remainder = decNumber % 16;

                switch (remainder.ToString())
                {
                    case "10":
                        hex.Add("A");
                        break;
                    case "11":
                        hex.Add("B");
                        break;
                    case "12":
                        hex.Add("C");
                        break;
                    case "13":
                        hex.Add("D");
                        break;
                    case "14":
                        hex.Add("E");
                        break;
                    case "15":
                        hex.Add("F");
                        break;
                    default:
                        hex.Add(remainder.ToString());
                        break;
                }
            }
            decNumber /= 16;
        }
        hex.Reverse();
        return hex;
    }
}