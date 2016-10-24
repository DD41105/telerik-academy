using System;

namespace Sort3Numbers
{
    class Sort3Numbers
    {
        static void Main()
        {
            double A = double.Parse(Console.ReadLine());
            double B = double.Parse(Console.ReadLine());
            double C = double.Parse(Console.ReadLine());

            if (A > B && A > C)
            {
                if (B > C)
                {
                    Console.WriteLine("{0} {1} {2}", A, B, C);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", A, C, B);
                }
            }
            else if (B > A && B > C)
            {
                if (A > C)
                {
                    Console.WriteLine("{0} {1} {2}", B, A, C);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", B, C, A);
                }
            }
            else if (C > A && C > B)
            {
                if (A > B)
                {
                    Console.WriteLine("{0} {1} {2}", C, A, B);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", C, B, A);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", A, B, C);
            }
        }
    }
}