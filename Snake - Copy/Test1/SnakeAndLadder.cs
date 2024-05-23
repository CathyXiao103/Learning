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
        public GameMap gameMap;
        public bool PlayerCanStart { get; set; } = false;
        public int Position { get; set; }

        public SnakeAndLaddersGame()
        {
            // Initialize the game map
            gameMap = new GameMap();

        }

        public IEnumerable<Tile> InitializeMap()
        {
            var map = new List<Tile>();
            for (var i = 0; i < 72; i++)
            {
                if (i == 2)
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
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }


        public bool PlayerStartPosition(int diceNumber)
        {
            if (diceNumber == 6)
                PlayerCanStart = true;
            return PlayerCanStart; // Test player stays on start until roll 6
        }

        public bool PlayerWin(int position)
        {
            return position == 9; // Position 9 is the winning position
        }
    }

    public enum TileType
    {
        Snake,
        Ladder,
        Blank
    }
}
