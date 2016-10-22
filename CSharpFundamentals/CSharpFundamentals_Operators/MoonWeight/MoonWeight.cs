using System;

namespace MoonWeight
{
    class MoonWeight
    {
        static void Main()
        {
            float W = float.Parse(Console.ReadLine());
            float M = 0.170f * W;
            Console.WriteLine(M.ToString("N3"));
        }
    }
}