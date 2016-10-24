using System;

namespace BiggestOf3
{
    class BiggestOf3
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                Console.WriteLine(A);
            }
            else if (B > A && B > C)
            {
                Console.WriteLine(B);
            }
            else if (C > A && C > B)
            {
                Console.WriteLine(C);
            }
            else
            {
                Console.WriteLine(A);
            }
        }
    }
}