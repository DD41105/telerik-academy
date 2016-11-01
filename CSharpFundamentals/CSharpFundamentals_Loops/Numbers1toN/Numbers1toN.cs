using System;

namespace Numbers1toN
{
    class Numbers1toN
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}