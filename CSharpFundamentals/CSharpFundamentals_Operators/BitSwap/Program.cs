using System;

class BitSwap
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int qPosition = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        for (int i = position; i < position + k; i++)
        {
            int mask1 = 1 << i;
            int mask2 = mask1 & number;
            int bit = mask2 >> i;

            int mask3 = 1 << qPosition;
            int mask4 = mask3 & number;
            int bit1 = mask4 >> qPosition;

            if (bit == 0)
            {
                int mask5 = ~(1 << qPosition);
                number = mask5 & number;
                if (bit != bit1)
                {
                    int mask6 = 1 << i;
                    number = mask6 | number;
                }
            }
            else if (bit == 1)
            {
                int mask7 = 1 << qPosition;
                number = mask7 | number;
                if (bit != bit1)
                {
                    int mask8 = ~(1 << i);
                    number = mask8 & number;
                }
            }
            qPosition++;
        }
        Console.WriteLine(number);
    }
}