using System;

namespace CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main()
        {
            string input = Console.ReadLine();
            CheckIsItCorrect(input);
        }

        private static void CheckIsItCorrect(string input)
        {
            char[] arr = input.ToCharArray();
            int bracketsCount = 0;
            bool isCorrect = true;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == '(')
                {
                    bracketsCount++;
                }
                else if (arr[i] == ')')
                {
                    bracketsCount--;
                }
                if (bracketsCount < 0)
                {
                    break;
                }
            }

            if (bracketsCount == 0)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }
        }
    }
}