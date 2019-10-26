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
            List<Pebble> returnedList = new List<Pebble>();

            if (getPebbleByXY(pebble.X - 1, pebble.Y).team == pebble.team)
            {
                returnedList.Add(getPebbleByXY(pebble.X - 1, pebble.Y));
            }
            if (getPebbleByXY(pebble.X + 1, pebble.Y).team == pebble.team)
            {
                returnedList.Add(getPebbleByXY(pebble.X + 1, pebble.Y));
            }
            if (getPebbleByXY(pebble.X, pebble.Y + 1).team == pebble.team)
            {
                returnedList.Add(getPebbleByXY(pebble.X, pebble.Y+1));
            }
            if (getPebbleByXY(pebble.X, pebble.Y -1 ).team == pebble.team)
            {
                returnedList.Add(getPebbleByXY(pebble.X, pebble.Y-1));
            }

            return returnedList;
        }
    }
}
