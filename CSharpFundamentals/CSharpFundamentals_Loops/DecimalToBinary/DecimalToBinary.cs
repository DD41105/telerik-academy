using System;
using System.Collections.Generic;

namespace DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            string result = null;

            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    list.Add("0");
                }
                else
                {
                    list.Add("1");
                }
                n = n / 2;
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
}