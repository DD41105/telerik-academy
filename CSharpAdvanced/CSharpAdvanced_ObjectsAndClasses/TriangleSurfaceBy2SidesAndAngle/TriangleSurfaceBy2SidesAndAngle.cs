using System;

namespace TriangleSurfaceBy2SidesAndAngle
{
    class TriangleSurfaceBy2SidesAndAngle
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double angle = double.Parse(Console.ReadLine());
            double angleRadians = angle * (Math.PI / 180);

            double result = (A * B * Math.Sin(angleRadians) / 2);
            Console.WriteLine("{0:F2}", result);
        }
    }
}