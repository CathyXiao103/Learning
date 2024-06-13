
namespace SnakeAndLadderGame
{
    public class Player
    {
        public int Position { get;  set; }
        public string PlayerName { get; set; }
        public bool CanStart { get;  set; } 
        public Player(string playerName)
        {
            Position = 1;
            PlayerName= playerName;
            CanStart = false;

        }
        public bool CanPlayerStart(int diceNumber)
        {
            if (diceNumber == 6)
                CanStart = true;
            return CanStart; // Test player stays on start until roll 6
        }
        public int DiceRoll()
        {
            Random random = new Random();
            return random.Next(1, 7);
        }

        public void Move(int diceNumber, List<Tile> gameMap)
        {
            Position += diceNumber;

            var currentTile = gameMap[Position];

            if (currentTile.TileType == TileType.Snake || currentTile.TileType == TileType.Ladder)
            {
                Position = currentTile.PositionToTakeTo;
            }
        }

        public bool IsWinner(int position)
        {
            return position == 72;

        }
    }
}