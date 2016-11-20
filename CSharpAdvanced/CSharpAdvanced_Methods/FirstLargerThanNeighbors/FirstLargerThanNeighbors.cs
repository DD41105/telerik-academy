using System;
using System.Linq;

namespace FirstLargerThanNeighbors
{
    class FirstLargerThanNeighbors
    {
        static int FindFirstLarger(int[] arr)
        {
            int indexOfFirst = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    continue;
                }
                else if (i == arr.Length - 1)
                {
                    continue;
                }
                else if (arr[i] > arr[i - 1] && arr[i] > arr[i+1])
                {
                    indexOfFirst = i;
                    break;
                }
            }
            if (indexOfFirst == 0)
            {
                indexOfFirst = -1;
            }


            return indexOfFirst;
        }
        static void Main()
        {
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int finalIndex = FindFirstLarger(numbers);

            Console.WriteLine(finalIndex);
        }
    }
}