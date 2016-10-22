using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            double x = Double.Parse(Console.ReadLine());
            double y = Double.Parse(Console.ReadLine());
            double distance = Math.Sqrt((x * x) + (y * y));

            if (distance <= 2) 
            {
                Console.WriteLine("yes" + " " + distance.ToString("N2"));
            }
            else
            {
                Console.WriteLine("no" + " " + distance.ToString("N2"));
            }
        }
    }
}