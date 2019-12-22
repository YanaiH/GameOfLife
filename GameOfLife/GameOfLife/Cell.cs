using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Cell
    {
        private bool Alive;

        public Cell(bool IsAlive)
        {
            this.Alive = IsAlive;
        }

        public bool IsAlive()
        {
            return Alive;
        }

        public void Die()
        {
            Alive = false;
        }

        public void Birth()
        {
            Alive = true;
        }
    }
}
