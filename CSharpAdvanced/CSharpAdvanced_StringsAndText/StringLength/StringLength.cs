using System;
using System.Text;

namespace StringLength
{
    class StringLength
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder(Console.ReadLine());
            for (int i = str.Length; i < 20; i++)
            {
                str.Append("*");
            }
            Console.WriteLine(str);
        }
    }
}