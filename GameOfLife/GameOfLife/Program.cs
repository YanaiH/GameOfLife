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
            GameOfLife game = new GameOfLife(5);
            while (game.IsStillAlive())
            {
                game.NextRound();
                System.Threading.Thread.Sleep(900);
            }
            Console.WriteLine("Game died after {0} rounds.",game.GetNumOfRoundsPlayed());
            Console.ReadKey();

        }
    }
}
