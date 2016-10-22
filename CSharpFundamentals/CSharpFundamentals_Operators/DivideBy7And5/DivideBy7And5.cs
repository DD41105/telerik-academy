using System;

namespace DivideBy7And5
{
    class DivideBy7And5
    {
        static void Main()
        {
            int inputNum = Int32.Parse(Console.ReadLine());
            if (inputNum % 7 == 0 && inputNum %5 == 0)
            {
                Console.WriteLine("true" + " " + inputNum);
            }
            else
            {
                Console.WriteLine("false" + " " + inputNum);
            }
        }
    }
}
