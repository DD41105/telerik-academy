using System;
using System.Linq;

namespace GetLargestNumber
{
    class GetLargestNumber
    {
        static int GetMax(int A, int B)
        {
            int max = Math.Max(A, B);
            return max;
        }

        static void Main()
        {
            int[] numbers = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int result = GetMax(GetMax(numbers[0], numbers[1]), numbers[2]);
            Console.WriteLine(result);
        }
    }
}