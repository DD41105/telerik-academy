using System;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace FallingRocks
{
    class FallingRocks
    {
        static void DrawPlayer(int locationX, int locationY, char player)
        {
            Console.SetCursorPosition(locationX, locationY);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write(player);
        }

        static void DrawRock(Rock Rock)
        {
            Console.SetCursorPosition(Rock._rockX, Rock._rockY);
            Console.ForegroundColor = Rock._color;
            Console.Write(Rock._rock);
        }

        static void Main()
        {
            // define the variables
            bool gameRunning = true;
            int windowHeight = 25;
            int windowWidth = 55;
            int locationX = 27;
            int locationY = 24;
            char player = (char)'ʘ';
            Stopwatch stopWatch = new Stopwatch();
            Random random = new Random();

            // console settings
            Console.Title = "Falling Rocks by D Dimov";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.OutputEncoding = Encoding.Unicode;
            Console.CursorVisible = false;
            Console.BufferHeight = Console.WindowHeight = windowHeight;
            Console.BufferWidth = Console.WindowWidth = windowWidth;

            // create the rocks
            Rock rock1 = new Rock(random.Next(55), 0, (char)'@', ConsoleColor.Red);
            Rock rock2 = new Rock(random.Next(55), 0, (char)'#', ConsoleColor.Blue);
            Rock rock3 = new Rock(random.Next(55), 0, (char)'$', ConsoleColor.Green);
            Rock rock4 = new Rock(random.Next(55), 0, (char)'%', ConsoleColor.Yellow);
            Rock rock5 = new Rock(random.Next(55), 0, (char)'&', ConsoleColor.Magenta);
            Rock rock6 = new Rock(random.Next(55), 0, (char)'*', ConsoleColor.Cyan);

            // initialization of the player and the rocks
            DrawPlayer(27, 24, (char)'ʘ');
            DrawRock(rock1);
            DrawRock(rock2);
            DrawRock(rock3);
            DrawRock(rock4);
            DrawRock(rock5);
            DrawRock(rock6);

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape && gameRunning == true)
            {
                Console.Write(player);
                stopWatch.Start();
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                        if (locationX < 54)
                        {
                            Console.Clear();
                            locationX++;
                            DrawPlayer(locationX, locationY, player);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (locationX > 0)
                        {
                            Console.Clear();
                            locationX--;
                            DrawPlayer(locationX, locationY, player);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (locationY > 0)
                        {
                            Console.Clear();
                            locationY--;
                            DrawPlayer(locationX, locationY, player);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (locationY < 24)
                        {
                            Console.Clear();
                            locationY++;
                            DrawPlayer(locationX, locationY, player);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                        }
                        break;
                }
            }

            // final screen after game ends
            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Time survived: " + ts);
            Console.WriteLine("");
        }
    }
}