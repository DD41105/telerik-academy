using System;

namespace MaximalKsum
{
    class MaximalKsum
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int sum = 0;

            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array1);
            Array.Reverse(array1);

            for (int i = 0; i < K; i++)
            {
                sum += array1[i];
            }

            Console.WriteLine(sum);
        }
    }
}