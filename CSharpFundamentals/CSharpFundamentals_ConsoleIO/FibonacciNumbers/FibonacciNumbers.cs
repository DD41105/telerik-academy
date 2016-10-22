using System;

namespace FibonacciNumbers
{
    class FibonacciNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long prev = 0, next = 1, sum = 1;
            string line = "";

            line += prev.ToString() + ", " + next.ToString();

            if (n >= 1 && n <= 50)
            {
                if (n < 2)
                {
                    line = prev.ToString();
                }

                for (int i = 2; i < n; i++)
                {
                    sum = prev + next;
                    prev = next;
                    next = sum;
                    line += ", " + next;
                }

                Console.WriteLine(line);
            }
        }
    }
}