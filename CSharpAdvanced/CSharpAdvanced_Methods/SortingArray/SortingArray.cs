using System;
using System.Linq;

namespace SortingArray
{
    class SortingArray
    {
        static void Reverse(int[] arr)
        {
            Array.Sort(arr);

            foreach (int number in arr)
            {
                Console.Write(number + " ");
            }
        }

        static void Main()
        {
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Reverse(numbers);
        }
    }
}