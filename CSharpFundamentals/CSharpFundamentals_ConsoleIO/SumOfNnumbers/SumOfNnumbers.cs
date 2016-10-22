using System;

namespace SumOfNnumbers
{
    class SumOfNnumbers
    {
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            double sum = 0;
            for (double i = 0; i < n; i++)
            {
                double input = double.Parse(Console.ReadLine());
                sum = sum + input;
            }
            Console.WriteLine(sum);
        }
    }
}