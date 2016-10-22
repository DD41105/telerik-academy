using System;

class ModifyBit
{
    static void Main()
    {
        ulong number = ulong.Parse(Console.ReadLine());
        int position = byte.Parse(Console.ReadLine());
        byte bitValue = byte.Parse(Console.ReadLine());

        if (position > 0 && position < 65 && bitValue == 0)
        {
            ulong mask = (ulong)~(1 << position);
            number = mask & number;
            Console.WriteLine(number);
        }
        else if (position > 0 && position < 65 && bitValue == 1)
        {
            ulong mask = (ulong)1 << position;
            number = mask | number;
            Console.WriteLine(number);
        }
    }
}