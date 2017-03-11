using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minesweeper
{
    public class Mines
    {
        public class Points
        {
            string name;
            int score;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Score
            {
                get { return score; }
                set { score = value; }
            }

            public Points()
            {

            }

            public Points(string name, int score)
            {
                this.name = name;
                this.score = score;
            }
        }

        static void Main(string[] args)
        {
            const int MAX = 35;

            string command = string.Empty;
            char[,] field = CreateGamingField();
            char[,] bombs = SetTheBombs();
            int counter = 0;
            bool bang = false;
            List<Points> champions = new List<Points>(6);
            int row = 0;
            int column = 0;
            bool firstFlag = true;
            bool secondFlag = false;
            
            do
            {
                if (firstFlag)
                {
                    Console.WriteLine("Come on, let's play MINESWEEPER! Try your luck by finding the squares without mines." +
                        "The 'top' command shows the standings, 'restart' starts a new game, 'exit' quits.");
                    Clear(field);
                    firstFlag = false;
                }

                Console.Write("Please input ROW and COLUMN : ");
                command = Console.ReadLine().Trim();

                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        Standings(champions);
                        break;
                    case "restart":
                        field = CreateGamingField();
                        bombs = SetTheBombs();
                        Clear(field);
                        bang = false;
                        firstFlag = false;
                        break;
                    case "exit":
                        Console.WriteLine("See you later!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                itIsYourTurn(field, bombs, row, column);
                                counter++;
                            }
                            if (MAX == counter)
                            {
                                secondFlag = true;
                            }
                            else
                            {
                                Clear(field);
                            }
                        }
                        else
                        {
                            bang = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nERROR! Invalid command!\n");
                        break;
                }

                if (bang)
                {
                    Clear(bombs);
                    Console.Write("\nDamn! You died with {0} points. " +
                        "Enter your name: ", counter);
                    string playerName = Console.ReadLine();

                    Points playerScore = new Points(playerName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(playerScore);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Score < playerScore.Score)
                            {
                                champions.Insert(i, playerScore);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((Points r1, Points r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Points r1, Points r2) => r2.Score.CompareTo(r1.Score));
                    Standings(champions);

                    field = CreateGamingField();
                    bombs = SetTheBombs();
                    counter = 0;
                    bang = false;
                    firstFlag = true;
                }

                if (secondFlag)
                {
                    Console.WriteLine("\nWell done! You opened 35 boxes.");
                    Clear(bombs);
                    Console.WriteLine("Enter your name : ");
                    string playerName = Console.ReadLine();
                    Points playerScore = new Points(playerName, counter);
                    champions.Add(playerScore);
                    Standings(champions);
                    field = CreateGamingField();
                    bombs = SetTheBombs();
                    counter = 0;
                    secondFlag = false;
                    firstFlag = true;
                }
            }
            while (command != "exit");

            Console.WriteLine("Made in Bulgaria");
            Console.WriteLine("As part of the Telerik Academy courses.");
            Console.Read();
        }

        private static void Standings(List<Points> points)
        {
            Console.WriteLine("\nSCORES:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} boxes",
                        i + 1, points[i].Name, points[i].Score);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty standings!\n");
            }
        }

        private static void itIsYourTurn(char[,] field,
            char[,] bombs, int row, int column)
        {
            char howManyBombs = Calculate(bombs, row, column);
            bombs[row, column] = howManyBombs;
            field[row, column] = howManyBombs;
        }

        private static void Clear(char[,] board)
        {
            int totalRows = board.GetLength(0);
            int totalCols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < totalRows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < totalCols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGamingField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetTheBombs()
        {
            int rows = 5;
            int cols = 10;
            char[,] playingField = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    playingField[i, j] = '-';
                }
            }

            List<int> totalRows = new List<int>();
            while (totalRows.Count < 15)
            {
                Random random = new Random();
                int nextRandom = random.Next(50);
                if (!totalRows.Contains(nextRandom))
                {
                    totalRows.Add(nextRandom);
                }
            }

            foreach (int i in totalRows)
            {
                int column = (i / cols);
                int row = (i % cols);
                if (row == 0 && i != 0)
                {
                    column--;
                    row = cols;
                }
                else
                {
                    row++;
                }
                playingField[column, row - 1] = '*';
            }

            return playingField;
        }

        private static void CalculateField(char[,] field)
        {
            int col = field.GetLength(0);
            int row = field.GetLength(1);

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char howMuch = Calculate(field, i, j);
                        field[i, j] = howMuch;
                    }
                }
            }
        }

        private static char Calculate(char[,] field, int passedRows, int passedCols)
        {
            int count = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (rows - 1 >= 0)
            {
                if (field[rows - 1, passedCols] == '*')
                {
                    count++;
                }
            }
            if (rows + 1 < rows)
            {
                if (field[rows + 1, passedCols] == '*')
                {
                    count++;
                }
            }
            if (passedCols - 1 >= 0)
            {
                if (field[rows, passedCols - 1] == '*')
                {
                    count++;
                }
            }
            if (passedCols + 1 < cols)
            {
                if (field[rows, passedCols + 1] == '*')
                {
                    count++;
                }
            }
            if ((rows - 1 >= 0) && (passedCols - 1 >= 0))
            {
                if (field[rows - 1, passedCols - 1] == '*')
                {
                    count++;
                }
            }
            if ((rows - 1 >= 0) && (passedCols + 1 < cols))
            {
                if (field[rows - 1, passedCols + 1] == '*')
                {
                    count++;
                }
            }
            if ((rows + 1 < rows) && (passedCols - 1 >= 0))
            {
                if (field[rows + 1, passedCols - 1] == '*')
                {
                    count++;
                }
            }
            if ((rows + 1 < rows) && (passedCols + 1 < cols))
            {
                if (field[rows + 1, passedCols + 1] == '*')
                {
                    count++;
                }
            }
            return char.Parse(count.ToString());
        }
    }
}