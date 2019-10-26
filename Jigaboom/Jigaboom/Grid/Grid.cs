using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Jigaboom.Grid
{
    class Grid
    {
        Dictionary pebbles = new Dictionary<Tuple<int, int>, int>();
        int getPebbleByXY(int x, int y)
        {
           return pebbles[new Tuple(x,y)];
        }

        List<Tuple<int,int>> getAdjasentfreespots(Tuple<int,int> pebble)
        {
            List<Tuple<int, int>> returnedList = new List<Tuple<int, int>>();

            if (pebbles[pebble.Item1 - 1, pebble.Item2] == 0)
                returnedList.Add(pebbles[pebble.Item1 - 1, pebble.Item2]);
            if (pebbles[pebble.Item1 +1, pebble.Item2] == 0)
                returnedList.Add(pebbles[pebble.Item1 + 1, pebble.Item2]);
            if (pebbles[pebble.Item1, pebble.Item2 - 1] == 0)
                returnedList.Add(pebbles[pebble.Item1 , pebble.Item2 -1]);
            if (pebbles[pebble.Item1, pebble.Item2 + 1] == 0)
                returnedList.Add(pebbles[pebble.Item1, pebble.Item2 + 1]);
            return returnedList;
        }

        Tuple<int,int> GetFreeAdjasentSpot(Pebble p)
        {
            
        }
    }
}
