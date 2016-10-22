using System;

namespace FourDigits
{
    class FourDigits
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int digit4 = number % 10;
            int digit3 = number / 10 % 10;
            int digit2 = number / 100 % 10;
            int digit1 = number / 1000;

            Console.WriteLine(digit1 + digit2 + digit3 + digit4);

            Console.WriteLine("{3}{2}{1}{0}", digit1, digit2, digit3, digit4);

            Console.WriteLine("{3}{0}{1}{2}", digit1, digit2, digit3, digit4);

            Console.WriteLine("{0}{2}{1}{3}", digit1, digit2, digit3, digit4);
        }
    }
}