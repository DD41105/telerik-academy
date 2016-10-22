using System;

namespace Circle
{
    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            Console.WriteLine("{0:F2} {1:F2}\n",
            2 * r * Math.PI, r * r * Math.PI);
        }
    }
}