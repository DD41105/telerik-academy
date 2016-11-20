using System;

namespace EnglishDigit
{
    class EnglishDigit
    {
        static void LastDigitIs(int input)
        {
            int lastNumber = input % 10;
            string digit = "";

            switch (lastNumber)
            {
                case 1: digit = "one";
                    Console.WriteLine(digit);
                    break;
                case 2:
                    digit = "two";
                    Console.WriteLine(digit);
                    break;
                case 3:
                    digit = "three";
                    Console.WriteLine(digit);
                    break;
                case 4:
                    digit = "four";
                    Console.WriteLine(digit);
                    break;
                case 5:
                    digit = "five";
                    Console.WriteLine(digit);
                    break;
                case 6:
                    digit = "six";
                    Console.WriteLine(digit);
                    break;
                case 7:
                    digit = "seven";
                    Console.WriteLine(digit);
                    break;
                case 8:
                    digit = "eight";
                    Console.WriteLine(digit);
                    break;
                case 9:
                    digit = "nine";
                    Console.WriteLine(digit);
                    break;
                case 0:
                    digit = "zero";
                    Console.WriteLine(digit);
                    break;
                default: digit = "";
                    Console.WriteLine(digit);
                    break;
            }
        }

        static void Main()
        {
            LastDigitIs(int.Parse(Console.ReadLine()));
        }
    }
}