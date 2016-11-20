using System;

namespace ReverseNumber
{
    class ReverseNumber
    {
        static string ReverseNum(string input)
        {
            string reversed = "";
            string s = input.ToString();
            char[] tempArr = s.ToCharArray();
            Array.Reverse(tempArr);
            reversed = new string(tempArr);
            return reversed;
        }

        static void Main()
        {
            string input = Console.ReadLine();

            Console.WriteLine(ReverseNum(input));
        }
    }
}