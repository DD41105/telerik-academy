using System;

namespace QuadraticEquation
{
    class QuadraticEquation
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            if (a == 0)
            {
                Console.WriteLine("{0:F2}", -c / b);
            }
            else
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant == 0)
                {
                    Console.WriteLine("{0:F2}", -b / (2 * a));
                }
                else if (discriminant < 0)
                {
                    Console.WriteLine("no real roots");
                }
                else if (discriminant > 0)
                {
                    double result1 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                    double result2 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                    Console.WriteLine("{0:F2}", Math.Min(result1, result2));
                    Console.WriteLine("{0:F2}", Math.Max(result1, result2));
                }
            }
        }
    }
}