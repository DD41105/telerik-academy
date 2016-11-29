using System;
using System.Text.RegularExpressions;

namespace ReplaceТags
{
    class ReplaceTags
    {
        static void Main(string[] args)
        {  
            //input
            string input = Console.ReadLine();
            //regular expression
            string output = Regex.Replace(input, @"<a.href=""([^>]*)"">([^<]*(?:(?!</a)<[^<]*)*)</a>", "[$2]($1)");
            //print
            Console.WriteLine(output);
        }
    }
}