using System;
using System.Linq;

namespace CSharpOOP_ExtMethodsDelegatesLambda
{
    class _06
    {
        static void Main()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 50, 42, 63 };
            
            // with lambda
            var resultWithLambda = array.Where((intiger) => (intiger % 7 == 0) && (intiger % 3 == 0)).Select((intiger) => intiger);

            foreach (var intiger in resultWithLambda)
            {
                Console.WriteLine(intiger);
            }
            
            // with Linq
            var resultWithLINQ =
                from intiger in array
                where intiger % 3 == 0 && intiger % 7 == 0
                select intiger;

            foreach (var intiger in resultWithLINQ)
            {
                Console.WriteLine(intiger);
            }
        }
    }
}