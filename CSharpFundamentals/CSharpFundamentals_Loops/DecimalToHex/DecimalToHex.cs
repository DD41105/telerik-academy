using System;
using System.Collections.Generic;
using System.Numerics;

class DecimalToHex
{
    static void Main()
    {
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        List<string> list = new List<string>();
        string result = null;
        BigInteger remainder = 0;

        while (n > 0)
        {
            if (n % 16 == 0)
            {
                list.Add("0");
            }
            else
            {
                remainder = n % 16;

                switch (remainder.ToString())
                {
                    case "10":
                        list.Add("A");
                        break;
                    case "11":
                        list.Add("B");
                        break;
                    case "12":
                        list.Add("C");
                        break;
                    case "13":
                        list.Add("D");
                        break;
                    case "14":
                        list.Add("E");
                        break;
                    case "15":
                        list.Add("F");
                        break;
                    default:
                        list.Add(remainder.ToString());
                        break;
                }
            }
            n = n / 16;
        }
        result = string.Join("", list.ToArray());
        Console.WriteLine(StringHelper.ReverseString(result));
    }
    static class StringHelper
    {
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}