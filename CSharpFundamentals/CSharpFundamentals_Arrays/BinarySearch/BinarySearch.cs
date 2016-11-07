using System;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main()
        {
            // input N and create the array
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];

            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }
            // input X
            int X = int.Parse(Console.ReadLine());

            // logic
            for (int i = 0; i < N; i++)
            {
                if (X == array1[i])
                {
                    Console.WriteLine("{0}", i);
                    break;
                }
                else if (X != array1[i])
                {
                    if (i == N-1)
                    {
                        Console.WriteLine(-1);
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
    }
}