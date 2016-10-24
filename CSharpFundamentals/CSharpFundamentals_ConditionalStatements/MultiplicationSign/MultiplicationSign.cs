using System;

namespace MultiplicationSign
{
    class MultiplicationSign
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if ((A * B * C) > 0 )
            {
                Console.WriteLine("+");
            }
            else if ((A * B * C) < 0)
            {
                Console.WriteLine("-");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}