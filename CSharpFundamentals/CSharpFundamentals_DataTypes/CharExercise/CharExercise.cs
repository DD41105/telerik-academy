using System;
using System.Text;

namespace CharExercise
{
    class CharExercise
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            char copyright = '\u00A9';
            Console.WriteLine("{0} \n {0} {0} \n {0} {0} {0}", copyright);
        }
    }
}
