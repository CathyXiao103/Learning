using SnakeAndLadderGame;

var player1 = new Player() { Position = 0 };

var board = new GameBoard() { NumberOfTiles = 72 };

var ladders = new List<Ladder>()
{
    new Ladder() {Position = 3, TargetPosition = 7},
    new Ladder() {Position = 20,TargetPosition = 40}
};

var snakes = new List<Snake>()
{
    new Snake(){Position = 16,TargetPosition = 6},
    new Snake(){Position = 47,TargetPosition = 26}
};

while (player1.Position < board.NumberOfTiles)
{
    // Roll the dice
    var diceRoll = RollDice();
    Console.WriteLine($"Player rolled a {diceRoll}.");

    // Move the player
    player1.Position += diceRoll;
    Console.WriteLine($"Player moved to position {player1.Position}.");

    // Check if the player landed on a ladder
    var ladder = ladders.FirstOrDefault(l => l.Position == player1.Position);
    if (ladder != null)
    {
        player1.Position = ladder.TargetPosition;
        Console.WriteLine($"Player landed on a ladder! Moved to position {player1.Position}.");
    }

    // Check if the player landed on a snake
    var snake = snakes.FirstOrDefault(s => s.Position == player1.Position);
    if (snake != null)
    {
        player1.Position = snake.TargetPosition;
        Console.WriteLine($"Player landed on a snake! Moved to position {player1.Position}.");
    }

    // Check if the game ends
    if (player1.Position >= board.NumberOfTiles)
    {
        Console.WriteLine("Game Over");
        break;
    }
    Thread.Sleep(1000);
}

int RollDice()
{
    Random random = new Random();
    return random.Next(1, 7);
}