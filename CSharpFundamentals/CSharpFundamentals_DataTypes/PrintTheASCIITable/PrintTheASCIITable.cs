using System;
using System.Text;

namespace PrintTheASCIITable
{
    class PrintTheASCIITable
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine();

            for (int i = 33; i <= 126; i++)
            {
                if ((i + 3) % 6 == 0)
                {
                    Console.WriteLine();
                }
                Console.Write("{1:000}: {0, -4}", (char)i, i);
            }
            Console.WriteLine();
        }
    }
}