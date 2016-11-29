using System;

namespace SubstringInText
{
    class SubstringInText
    {
        static void Main()
        {
            string searchingSubstring = Console.ReadLine();
            string text = Console.ReadLine();
            int repeatingTimes = 0;

            for (int index = 0; ; repeatingTimes++)
            {
                int rc = text.IndexOf(searchingSubstring, index, StringComparison.OrdinalIgnoreCase);
                if (rc < 0)
                {
                    break;
                }
                index = rc + searchingSubstring.Length;
            }

            Console.WriteLine(repeatingTimes);
        }
    }
}