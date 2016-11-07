using System;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            char[] array1 = input1.ToCharArray();
            char[] array2 = input2.ToCharArray();

            for (int i = 0; i < Math.Min(array1.Length, array2.Length); i++)
            {
                if (array1[i] < array2[i])
                {
                    Console.WriteLine("<");
                    return;
                }
                if (array1[i] > array2[i])
                {
                    Console.WriteLine(">");
                    return;
                }
            }

            // reach this stage if all the i in the two arrays are equal

            if (array1.Length == array2.Length)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(array1.Length < array2.Length ? "<" : ">");
            }
        }
    }
}