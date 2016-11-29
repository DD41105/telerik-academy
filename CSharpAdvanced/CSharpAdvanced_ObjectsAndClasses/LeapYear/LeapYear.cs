using System;

namespace LeapYear
{
    class LeapYear
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            DateTime date = new DateTime(input, 12, 31);

            bool isLeap = false;

            if (date.Year % 4 == 0)
            {
                isLeap = true;
            }

            if (isLeap == true)
            {
                Console.WriteLine("Leap");
            }
            else
            {
                Console.WriteLine("Common");
            }
        }
    }
}