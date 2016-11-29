using System;
using System.Text;

namespace SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {  
            //input
            string input = Console.ReadLine();
            //calculation
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            int lastEqualDigit = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == output[lastEqualDigit])
                {
                    continue;
                }
                else
                {
                    output.Append(input[i]);
                    lastEqualDigit++;
                }
            }
            //print
            Console.WriteLine(output);
        }
    }
}