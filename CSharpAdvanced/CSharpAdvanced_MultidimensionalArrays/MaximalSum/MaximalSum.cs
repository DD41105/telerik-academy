using System;
using System.Linq;

namespace MaximalSum
{
    class MaximalSum
    {
        static void Main()
        {
            string[] size = Console.ReadLine().Split(' ');
            int N = int.Parse(size[0]);
            int M = int.Parse(size[1]);
            int[,] matrix = new int[N, M];
            int[,] subMatrix = new int[3, 3];
            int maxSum = int.MinValue;
            int tempSum = 0;

            for (int row = 0; row < N; row++)
            {
                int[] tempArr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                for (int col = 0; col < M; col++)
                {
                    matrix[row, col] = tempArr[col];
                }
                Array.Clear(tempArr, 0, tempArr.Length);
            }

            for (int row = 0; row < (N-2); row++)
            {
                for (int col = 0; col < (M - 2); col++)
                {
                    for (int subRow = row; subRow < (row + 3); subRow++)
                    {
                        for (int subCol = col; subCol < (col + 3); subCol++)
                        {
                            tempSum += matrix[subRow, subCol];
                        }
                    }
                    if (tempSum > maxSum)
                    {
                        maxSum = tempSum;
                    }
                    tempSum = 0;
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}