using System;

namespace SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            try
            {
                double input = double.Parse(Console.ReadLine());
                if (input < 0)
                {
                    Console.WriteLine("Invalid number");
                }
                else
                {
                    double result = Math.Sqrt(input);
                    Console.WriteLine("{0:F3}", result);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}