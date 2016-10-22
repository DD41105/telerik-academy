using System;

namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            int inputNum = Int32.Parse(Console.ReadLine());

            if (inputNum % 2 == 0)
            {
                Console.WriteLine("even" + " " + inputNum);
            }
            else
            {
                Console.WriteLine("odd" + " " + inputNum);
            }
        }
    }
}