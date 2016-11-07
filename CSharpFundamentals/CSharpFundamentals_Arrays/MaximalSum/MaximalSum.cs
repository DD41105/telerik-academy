using System;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int maxSum = 0;
            int currentSum = 0;
            int start = 0;
            int startTemp = 0;
            int end = 0;

            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < array1.Length; i++)
            {
                if (currentSum <= 0)
                {
                    currentSum = 0;
                    startTemp = i;
                }

                currentSum += array1[i];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    start = startTemp;
                    end = i;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}