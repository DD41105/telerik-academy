using System;

namespace QuickSort
{
    class QuickSort
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            QuickSortMethod(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join("\n", arr));
        }


        static void QuickSortMethod(int[] arr, int start, int end)
        {
            if (start < end)
            {
                int pivot = arr[end];
                int pIndex = start;
                for (int i = start; i < end; i++)
                {
                    if (arr[i] <= pivot) // swap
                    {
                        int temp = arr[i];
                        arr[i] = arr[pIndex];
                        arr[pIndex] = temp;

                        pIndex++;
                    }
                }

                arr[end] = arr[pIndex];
                arr[pIndex] = pivot;

                QuickSortMethod(arr, start, pIndex - 1);
                QuickSortMethod(arr, pIndex + 1, end);
            }
        }
    }
}