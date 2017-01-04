using System;
using System.Threading;

class Timer
{
    delegate void myTimer(int t);

    static void Main()
    {
        myTimer timer = delegate (int time)
        {
            while (true)
            {
                Thread.Sleep(time);
                Console.WriteLine("Done!");
            }
        };

        timer(800);
    }
}