using System;
using System.Text;
using System.Diagnostics;

namespace FallingRocks
{
    class FallingRocks
    {
        static void DrawPlayer(Player Player)
        {
                Console.SetCursorPosition(Player._locationX, Player._locationY);
                Console.ForegroundColor = Player._playerColor;
                Console.Write(Player._player);
        }

        static void DrawRock(Rock Rock)
        {
            Console.SetCursorPosition(Rock._rockX, Rock._rockY);
            Console.ForegroundColor = Rock._color;
            Console.Write(Rock._rock);
        }

        static void MoveRock(Rock Rock)
        {
            if (Rock._rockY < 24)
            {
                Console.SetCursorPosition(Rock._rockX, Rock._rockY);
                Rock._rockY++;
            }
            else
            {
                Collision(Rock , 24, true);
            }   
        }

        static void Collision(Rock Rock, int locationY, bool gameRunning)
        {
            if (Rock._rockY == locationY && gameRunning == true)
            {
                gameRunning = false;
            }
        }

        static void Main()
        {
            // define the variables
            bool gameRunning = true;
            int windowHeight = 25;
            int windowWidth = 55;
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
            // TODO: change the variables in the Collision method so that it works correctly
            Rock rock1 = new Rock(random.Next(55), 0, (char)'@', ConsoleColor.Red);
            Rock rock2 = new Rock(random.Next(55), 0, (char)'#', ConsoleColor.Blue);
            Rock rock3 = new Rock(random.Next(55), 0, (char)'$', ConsoleColor.Green);
            Rock rock4 = new Rock(random.Next(55), 0, (char)'%', ConsoleColor.Yellow);
            Rock rock5 = new Rock(random.Next(55), 0, (char)'&', ConsoleColor.Magenta);
            Rock rock6 = new Rock(random.Next(55), 0, (char)'*', ConsoleColor.Cyan);
            Player player1 = new Player(27, 24, (char)'ʘ', ConsoleColor.Blue);

            // initialization of the player and the rocks
            DrawPlayer(player1);
            DrawRock(rock1);
            DrawRock(rock2);
            DrawRock(rock3);
            DrawRock(rock4);
            DrawRock(rock5);
            DrawRock(rock6);

            stopWatch.Start();

            ConsoleKeyInfo keyInfo;
            while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape && gameRunning == true)
            {
                Console.Write(player1._player);
                switch (keyInfo.Key)
                {
                    case ConsoleKey.RightArrow:
                       if (player1._locationX < 54)
                        {
                            Console.Clear();
                            player1._locationX++;
                            DrawPlayer(player1);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                            MoveRock(rock1);
                            MoveRock(rock2);
                            MoveRock(rock3);
                            MoveRock(rock4);
                            MoveRock(rock5);
                            MoveRock(rock6);
                        }
                        else
                        {
                            player1._locationX--;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (player1._locationX > 0)
                        {
                            Console.Clear();
                            player1._locationX--;
                            DrawPlayer(player1);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                            MoveRock(rock1);
                            MoveRock(rock2);
                            MoveRock(rock3);
                            MoveRock(rock4);
                            MoveRock(rock5);
                            MoveRock(rock6);
                        }
                        else
                        {
                            player1._locationX++;
                        }
                        break;

                    case ConsoleKey.UpArrow:
                        if (player1._locationY > 0)
                        {
                            Console.Clear();
                            player1._locationY--;
                            DrawPlayer(player1);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                            MoveRock(rock1);
                            MoveRock(rock2);
                            MoveRock(rock3);
                            MoveRock(rock4);
                            MoveRock(rock5);
                            MoveRock(rock6);
                        }
                        else
                        {
                            gameRunning = false;
                        }
                        break;

                    case ConsoleKey.DownArrow:
                        if (player1._locationY < 24)
                        {
                            Console.Clear();
                            player1._locationY++;
                            DrawPlayer(player1);
                            DrawRock(rock1);
                            DrawRock(rock2);
                            DrawRock(rock3);
                            DrawRock(rock4);
                            DrawRock(rock5);
                            DrawRock(rock6);
                            MoveRock(rock1);
                            MoveRock(rock2);
                            MoveRock(rock3);
                            MoveRock(rock4);
                            MoveRock(rock5);
                            MoveRock(rock6);
                        }
                        else
                        {
                            gameRunning = false;
                        }
                        break;
                }
            }

            if (gameRunning == false)
            {
                stopWatch.Stop();
                TimeSpan ts = stopWatch.Elapsed;
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("Time survived: {0} minutes {1} seconds", ts.Minutes, ts.Seconds);
                Console.WriteLine("");
                Console.ReadLine();
            }
        }
    }
}