using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderGame
{
    public class SnakeAndLaddersGame
    {
        //private SnakeLadderMap gameMap;
        public List<Tile> GameMap { get;  set; }
        public SnakeAndLaddersGame()
        {
            GameMap = InitializeMap().ToList();
        }
        public IEnumerable<Tile> InitializeMap()
        {
            var map = new List<Tile>();
            for (var i = 0; i < 72; i++)
            {
                if (i == 7)
                {
                    map.Add(new Tile() { PositionToTakeTo = 3, TileType = TileType.Snake });
                    continue;
                }

                if (i == 10)
                {
                    map.Add(new Tile() { PositionToTakeTo = 16, TileType = TileType.Ladder });
                    continue;
                }

                map.Add(new Tile() { TileType = TileType.Blank });
            }

            return map;
        }
        public string Start()
        {
            return "Hello, Player. Roll the dice.";
        }
    
        public Player InitializePlayer(string playerName)
        {
            return new Player(playerName);
        }
    }

    public enum TileType
    {
        Snake,
        Ladder,
        Blank
    }
}
