using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratGame.Model
{
    public class Tile
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Unit Unit { get; set; } = null;
    }
}
