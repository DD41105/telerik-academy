using System;

namespace AllocateArray
{
    class AllocateArray
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] myArray = new int[N];

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i * 5);
            }
        }
    }
}