using System;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];

            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(array1);

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(array1[i]);
            }
        }
    }
}