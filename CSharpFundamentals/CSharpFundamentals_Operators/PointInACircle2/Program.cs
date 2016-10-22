using System;

namespace PointInACircle
{
    class PointInACircle
    {
        static void Main()
        {
            float x = float.Parse(Console.ReadLine());
            float y = float.Parse(Console.ReadLine());
            float radius = 2;

            if (x >= -1000 && x <= 1000 && y >= -1000 && y <= 1000)
            {
                bool inCircle = x * x + y * y <= radius * radius;
                float distance = (float)Math.Sqrt(x * x + y * y);

                if (inCircle == true)
                {
                    Console.WriteLine("yes {0:0.00}", distance);
                }
                else
                    Console.WriteLine("no {0:0.00}", distance);
            }
        }
    }
}