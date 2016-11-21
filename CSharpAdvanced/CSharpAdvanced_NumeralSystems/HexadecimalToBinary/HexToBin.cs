using System;

namespace HexadecimalToBinary
{
    class HexToBin
    {
        static void Main()
        {
            var hex = Console.ReadLine();
            hex = Convert.ToString(Convert.ToInt64(hex.ToString(), 16), 2);
            Console.WriteLine(hex);
        }
    }
}