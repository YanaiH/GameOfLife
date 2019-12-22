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
            for (int i = 0; i < matrixSize + 2; i++) 
            {
                for (int j = 0; j < matrixSize + 2; j++)
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
        }

        private void PrintMatrix()
        {
            Console.CursorVisible = false;
            Console.Clear();
            
            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++) 
                {
                    Console.SetCursorPosition(i, j);
                    if (matrix[i,j].IsAlive())
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    Console.Write(" ");
                }
            }
        }
    }
}
