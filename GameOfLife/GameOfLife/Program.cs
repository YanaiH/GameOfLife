using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            GameOfLife game = new GameOfLife(20);
            for (int i = 0; i < 30; i++)
            {
                game.NextRound();
                System.Threading.Thread.Sleep(500);
            }
            Console.ReadKey();

        }
    }
}
