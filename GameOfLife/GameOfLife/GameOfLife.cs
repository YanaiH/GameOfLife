using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class GameOfLife
    {
        private Cell[,] matrix;
        private int numOfRoundsPlayed;

        public GameOfLife(int matrixSize)
        {
            Random rnd = new Random();
            matrix = new Cell[matrixSize + 2, matrixSize + 2];
            for (int i = 1; i < matrixSize; i++)
            {
                for (int j = 1; j < matrixSize; j++)
                {
                    int temp = rnd.Next(0, 2);
                    if (temp == 0)
                    {
                        matrix[i, j] = new Cell(false);
                    }
                    else
                    {
                        matrix[i, j] = new Cell(true);
                    }
                }
            }
            numOfRoundsPlayed = 0;
            PrintMatrix();
        }


        public void NextRound()
        {
            for (int i = 1; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 2; j++)
                {
                    switch (CountAliveNeighbors(i, j))
                    {
                        case 2:
                            break;
                        case 3:
                            matrix[i, j].Birth();
                            break;
                        default:
                            matrix[i, j].Die();
                            break;
                    }
                }
            }
            PrintMatrix();
            numOfRoundsPlayed++;
        }

        public void PrintMatrix()
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;

            for (int i = 1; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 2; j++)
                {
                    Console.SetCursorPosition(i, j);
                    if (matrix[i, j].IsAlive())
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.Write(" ");
                    }
                }
            }
        }

        private int CountAliveNeighbors(int row, int column)
        {
            int count = 0;
            for (int i = row - 1; i <= row + 1; i++)
            {
                for (int j = column - 1; j <= column + 1; j++)
                {
                    if ((i != row || j != column) && matrix[i, j] != null)
                    {
                        if (matrix[i, j].IsAlive())
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }

        public bool IsStillAlive()
        {
            bool alive = false;
            for (int i = 1; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 1; j < matrix.GetLength(1) - 2; j++)
                {
                    if (matrix[i,j].IsAlive())
                    {
                        alive = true;
                    }
                }
            }
            return alive;
        }

        public int GetNumOfRoundsPlayed()
        {
            return numOfRoundsPlayed;
        }
    }
}
