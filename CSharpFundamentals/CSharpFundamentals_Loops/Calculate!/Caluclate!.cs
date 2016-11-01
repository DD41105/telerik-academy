using System;

class Calculate
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1 + 1 / x;
        ulong fact = 1;

        for (uint i = 2; i <= n; i++)
        {
            fact = fact * i;
            double pow = Math.Pow(x, i);
            sum = sum + (fact / pow);
        }
        Console.WriteLine("{0:F5}", sum);
    }
}