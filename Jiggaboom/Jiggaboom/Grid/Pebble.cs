using System;
using System.Collections.Generic;
using System.Text;

namespace Jigaboom.Grid
{
    class Pebble
    {
        public int X;
        public int Y;
        public int team;

        public Pebble(int X, int Y, int team)
        {
            this.X = X;
            this.Y = Y;
            this.team = team;
        }
    }
}
