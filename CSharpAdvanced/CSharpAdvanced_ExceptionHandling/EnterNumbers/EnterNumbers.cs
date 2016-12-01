using System;

namespace EnterNumbers
{
    class EnterNumbers
    {
        private static int ReadNumber(int start, int end)
        {
            int number = int.Parse(Console.ReadLine());
            if (number <= start || number >= end)
            {
                throw new System.ArgumentOutOfRangeException(String.Format("Integer {0} should be between {1} and {2}", number, start, end));
            }
            return number;
        }
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;
            try
            {
                int[] arr = new int[10];
                for (int i = 0; i < 10; i++)
                {
                    arr[i] = ReadNumber(i <= 0 ? start : arr[i - 1], end);
                }
                Console.Write("{0} < ", 1);
                foreach (var item in arr)
                {
                    Console.Write("{0} < ", item);
                }
                Console.WriteLine(100);
            }
            catch
            {
                Console.WriteLine("Exception");
            }
        }
    }
}