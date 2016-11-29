using System;
using System.Text;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string input = Console.ReadLine();
            bool isUpper = false;
            StringBuilder newString = new StringBuilder();

            for (int sIndex = 0; ; )
            {
                string pattern = isUpper ? "</upcase>" : "<upcase>";
                int rc = input.IndexOf(pattern, sIndex, StringComparison.OrdinalIgnoreCase);
                if (rc < 0)
                {
                    newString.Append(input.Substring(sIndex));
                    break;
                }
                string subStr = input.Substring(sIndex, rc - sIndex);
                newString.Append(isUpper ? subStr.ToUpper() : subStr);
                sIndex = rc + pattern.Length;
                isUpper = !isUpper;
            }
            Console.WriteLine(newString.ToString());
        }
    }
}