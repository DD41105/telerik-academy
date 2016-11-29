using System;
using System.Threading;
using System.Globalization;

namespace UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            //input
            string input = Console.ReadLine();
            //calculation and print
            for (int i = 0; i < input.Length; i++)
            {
                Console.Write("\\u{0:X4}", (int)input[i]);
            }
            Console.WriteLine();
        }
    }
}