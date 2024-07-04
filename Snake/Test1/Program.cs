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
void CheckForLadder()
{
    var ladder = ladders.FirstOrDefault(l => l.Position == player1.Position);
    if (ladder != null)
    {
        player1.Position = ladder.TargetPosition;
        Console.WriteLine($"Player landed on a ladder! Moved to position {player1.Position}.");
    }
}

void CheckForSnake()
{
    var snake = snakes.FirstOrDefault(s => s.Position == player1.Position);
    if (snake != null)
    {
        player1.Position = snake.TargetPosition;
        Console.WriteLine($"Player landed on a snake! Moved to position {player1.Position}.");
    }
}
void CheckForGameEnd()
{
    if (player1.Position >= board.NumberOfTiles)
    {
        Console.WriteLine("Game Over");
    }
}
while (player1.Position < board.NumberOfTiles)
{
    // Roll the dice
    var diceRoll = player1.RollDice();
    Console.WriteLine($"Player rolled a {diceRoll}.");

    // Move the player
    player1.Position += diceRoll;
    Console.WriteLine($"Player moved to position {player1.Position}.");

    // Check if the player landed on a ladder
    CheckForLadder();
    // Check if the player landed on a snake
    CheckForSnake();

    // Check if the game ends
    CheckForGameEnd();
    Thread.Sleep(1000);
}
