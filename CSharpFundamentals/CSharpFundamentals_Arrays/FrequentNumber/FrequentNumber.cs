using System;
using System.Collections.Generic;

namespace FrequentNumber
{
    class FrequentNumber
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] array1 = new int[N];
            int mostCommonValue = 0;
            int highestCount = 0;

            // add values to the array
            for (int i = 0; i < N; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            // create dictionary and loop through it with foreach
            var cnt = new Dictionary<int, int>();
            foreach (int value in array1)
            {
                if (cnt.ContainsKey(value))
                {
                    cnt[value]++;
                }
                else
                {
                    cnt.Add(value, 1);
                }

                foreach (KeyValuePair<int, int> pair in cnt)
                {
                    if (pair.Value > highestCount)
                    {
                        mostCommonValue = pair.Key;
                        highestCount = pair.Value;
                    }
                }
            }

            // output the result
            Console.WriteLine("{0} ({1} times)", mostCommonValue, highestCount);
        }
    }
}