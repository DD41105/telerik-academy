using System;
using System.Linq;

namespace MMSAofNnumbers
{
    class MMSAofNnumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            double[] array = new double[n];

            if (n > 0 && n < 1001)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = double.Parse(Console.ReadLine());
                }
                Console.WriteLine("min={0:F2}", array.Min());
                Console.WriteLine("max={0:F2}", array.Max());
                Console.WriteLine("sum={0:F2}", array.Sum());
                Console.WriteLine("avg={0:F2}", array.Average());
            }
        }
    }
}