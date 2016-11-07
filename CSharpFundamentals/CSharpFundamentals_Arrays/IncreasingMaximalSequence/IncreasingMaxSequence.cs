using System;

namespace IncreasingMaximalSequence
{
    class IncreasingMaxSequence
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int currentCount = 0;
            int highestCount = 0;

            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0, prev = 0; i < N; i++)
            {
                if (array1[i] > prev)
                {
                    currentCount++;
                    if (currentCount > highestCount)
                    {
                        highestCount = currentCount;
                    }
                }
                else
                {
                    currentCount = 1;
                }
                prev = array1[i];
            }

            Console.WriteLine(highestCount);
        }
    }
}