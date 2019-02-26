using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StratGame.Model
{
    public static class Game
    {
        public static Unit Soldier1 { get; set; } = new Unit()
        {
            Name = "S1"
        };

        public static Unit Soldier2 { get; set; } = new Unit()
        {
            Name = "S2"
        };

        public static Map BasicMap { get; set; } = new Map()
        {
            Tiles = new List<Tile>()
            {
                new Tile() {X = 0 , Y = 0},
                new Tile() {X = 0 , Y = 1, Unit = Soldier1 },
                new Tile() {X = 0 , Y = 2},
                new Tile() {X = 1 , Y = 0},
                new Tile() {X = 1 , Y = 1},
                new Tile() {X = 1 , Y = 2},
                new Tile() {X = 2 , Y = 0},
                new Tile() {X = 2 , Y = 1, Unit = Soldier2 },
                new Tile() {X = 2 , Y = 2}
            }
        };

        public static void Move(Unit u, int x, int y)
        {
            BasicMap.Tiles.Where(t => t.Unit == u).Single().Unit = null;
            BasicMap.Tiles.Where(t => t.X == x && t.Y == y).Single().Unit = u;
        }

    }
}
