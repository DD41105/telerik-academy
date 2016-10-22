using System;

namespace ThirdDigit
{
    class ThirdDigit
    {
        private const int searchedDigit = 7;

        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            int thirdDigit = (number / 100) % 10;
            if (thirdDigit == searchedDigit)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + thirdDigit);
            }
        }
    }
}