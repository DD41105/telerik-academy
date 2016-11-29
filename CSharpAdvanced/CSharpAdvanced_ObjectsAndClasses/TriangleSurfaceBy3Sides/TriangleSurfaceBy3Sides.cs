using System;

namespace TriangleSurfaceBy3Sides
{
    class TriangleSurfaceBy3Sides
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            double semiparam = (A + B + C) / 2;
            double result = Math.Sqrt(semiparam * (semiparam - A) * (semiparam - B) * (semiparam - C));
            Console.WriteLine("{0:F2}", result);
        }
    }
}