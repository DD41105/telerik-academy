using System;
using System.Linq;

namespace LargerThanNeighbors
{
    class LargerThanNeighbors
    {
        static bool IsLarger(int pos, int[] arr)
        {
            if (pos == arr.Length - 1)
            {
                return false;
            }
            else if (pos == 0)
            {
                return false;
            }
            else
            {
                if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1])
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        static void Main()
        {
            int counter = 0;
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                bool isItLarg = IsLarger(i, numbers);
                if (isItLarg == true)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
        }
    }
}