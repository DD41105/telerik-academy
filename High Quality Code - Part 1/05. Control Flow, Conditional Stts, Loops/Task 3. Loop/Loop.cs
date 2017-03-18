using System;

namespace Task_3.Loop
{
    class Loop
    {
        static void Main(string[] args)
        {
            int i = 0; // needed outside of the for loop so that it can be used in the IF statement below
            while (i < 100) // changed for -> while
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(array[i]);
                    if (array[i] == expectedValue)
                    {
                        i = 666;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine(array[i]);
                    i++;
                }
            

            // More code here
            if (i == 666)
            {
                Console.WriteLine("Value Found");
            }
        }
    }
}
