using System;
using System.Linq;

namespace AppearanceCount
{
    class AppearanceCount
    {
        static int CountAppearances(int num, int[] numbers)
        {
            int counter = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == num)
                {
                    counter++;
                }
            }

            Console.WriteLine(counter);
            return counter;
        }

        static void Main()
        {
            int sizeOfArr = int.Parse(Console.ReadLine());
            int[] arr = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int num = int.Parse(Console.ReadLine());

            CountAppearances(num, arr);
        }
    }
}