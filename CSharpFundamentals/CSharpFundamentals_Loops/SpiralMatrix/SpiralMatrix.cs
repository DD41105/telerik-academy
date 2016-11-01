using System;

namespace SpiralMatrix
{
    class SpiralMatrix
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[,] array = new int[n, n];
            int element = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n - i; j++)
                {
                    element++;
                    array[i, j] = element;
                }
                for (int k = i; k < n - i; k++)
                {
                    array[k, (n - i - 1)] = element;
                    element++;
                }
                element--;
                for (int l = (n - i - 1); l > i; l--)
                {
                    array[(n - i - 1), l] = element;
                    element++;
                }
                for (int m = n - i - 1; m > i; m--)
                {
                    array[m, i] = element;
                    element++;
                }
                element--;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}