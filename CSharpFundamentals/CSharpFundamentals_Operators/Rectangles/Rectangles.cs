using System;

namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            double width = Convert.ToDouble(Console.ReadLine());
            double height = Convert.ToDouble(Console.ReadLine());
            double perimeter = 2.0 * width + 2.0 * height;
            double area = width * height;

            Console.WriteLine("{0:0.00} {1:0.00}", area, perimeter);
        }
    }
}