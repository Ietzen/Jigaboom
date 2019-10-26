using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jigaboom.Grid
{
    class Grid
    {
        List<Pebble> pebbles = new List<Pebble>();
        
        Pebble getPebbleByXY(int x, int y)
        {
            foreach(Pebble pebble in pebbles)
            {
                if(pebble.X == x && pebble.Y == y)
                {
                    return pebble;
                }
            }
            return null;
        }

        List<Pebble> getAdjasentPebbles(Pebble pebble)
        {
            if()
        }
    }
}
