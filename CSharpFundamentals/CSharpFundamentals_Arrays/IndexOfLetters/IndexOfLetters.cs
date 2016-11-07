using System;

namespace IndexOfLetters
{
    class IndexOfLetters
    {
        static void Main()
        {
            char[] alphabet = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
            string input = Console.ReadLine();

            char[] array2 = input.ToCharArray();
            int[] indexes = new int[input.Length];
            int i = 0;

            foreach (char letter in array2)
            {
                indexes[i] = Array.IndexOf(alphabet, letter);
                i++;
            }

            for (int j = 0; j < indexes.Length; j++)
            {
                Console.WriteLine(indexes[j]);
            }
        }
    }
}