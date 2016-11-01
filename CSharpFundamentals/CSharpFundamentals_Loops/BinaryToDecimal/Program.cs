using System;

namespace BinaryToDecimal
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int output = Convert.ToInt32(input, 2);
            Console.WriteLine(output);
        }
    }
}