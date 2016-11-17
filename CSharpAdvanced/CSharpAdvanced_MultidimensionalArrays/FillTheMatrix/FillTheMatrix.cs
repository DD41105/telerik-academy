using System;

namespace FillTheMatrix
{
    class FillTheMatrix
    {
        static void Main()
        {
            int size = int.Parse(Console.ReadLine());
            char type = char.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            int counter = 1;

            if (type == 'a')
            {
                for (int row = 0; row < size; row++)
                {
                    for (int col = 0; col <= size; col++)
                    {
                        if (col == size)
                        {
                            counter = row + 2;
                            break;
                        }
                        matrix[row, col] = counter;
                        counter += size;
                    }
                }
            }
            else if (type == 'b')
            {
                for (int col = 0; col < size; col++)
                {
                    for (int row = 0; row < size; row++, counter++)
                    {
                        if ((col % 2 == 0))
                        {
                            matrix[row, col] = counter;
                        }
                        else
                        {
                            matrix[row, col] = counter + (size - (row * 2) - 1);
                        }
                    }
                }
            }
            else if (type == 'c')
            {
                // first half of the matrix
                for (int reversedRow = size - 1; reversedRow >= 0; reversedRow--)
                {
                    for (int col = 0; col < (size - reversedRow); col++, counter++)
                    {
                        if (col == 0)
                        {
                            matrix[reversedRow, col] = counter;
                        }
                        else
                        {
                            matrix[(reversedRow + col), col] = counter;
                        }
                    }
                }
                // second half of the matrix
                for (int col = 1; col < size; col++)
                {
                    for (int row = 0; row < (size - col); row++, counter++)
                    {
                        if (row == 0)
                        {
                            matrix[row, col] = counter;
                        }
                        else
                        {
                            matrix[row, (col + row)] = counter;
                        }
                    }
                }

            }
            else if (type == 'd')
            {
                for (int depth = 0; depth <= (size / 2); depth++)
                {
                    for (int down = depth; down <= size - depth - 1; down++, counter++)
                    {
                        matrix[down, depth] = counter;
                    }
                    for (int right = depth + 1; right <= size - depth - 1; right++, counter++)
                    {
                        matrix[(size - depth - 1), right] = counter;
                    }
                    for (int up = size - depth - 2; up > depth; up--, counter++)
                    {
                        matrix[up, (size - depth - 1)] = counter;
                    }
                    for (int left = size - depth - 1; left > depth; left--, counter++)
                    {
                        if (matrix[depth, left] == 0)
                        {
                            matrix[depth, left] = counter;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            // print the matrix
            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    // if it's the last element write it without a space at the end
                    if (col == size - 1)
                    {
                        Console.Write(matrix[row, col]);
                    }
                    else // other elements go here
                    {
                        Console.Write("{0} ", matrix[row, col]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}