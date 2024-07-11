using SnakeAndLadderGame;

var player1 = new Player() { Position = 0 };

var board = new GameBoard() { NumberOfTiles = 72 };

var ladders = new List<Ladder>()
{
    new Ladder() {Position = 4, TargetPosition = 14},
    new Ladder() {Position = 9, TargetPosition = 31},
    new Ladder() {Position = 21, TargetPosition = 42},
    new Ladder() {Position = 28, TargetPosition = 65},
    new Ladder() {Position = 38, TargetPosition = 68},
    new Ladder() {Position = 51,TargetPosition = 67}
};

var snakes = new List<Snake>()
{
    new Snake(){Position = 16,TargetPosition = 6},
    new Snake(){Position = 18,TargetPosition = 9},
    new Snake(){Position = 31,TargetPosition = 16},
    new Snake(){Position = 38,TargetPosition = 1},
    new Snake(){Position = 52,TargetPosition = 26},
    new Snake(){Position = 63,TargetPosition = 18},
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

void DrawBoard()
{
    Console.Clear();
    for (int i = 1; i <= board.NumberOfTiles; i++)
    {
        if (i == player1.Position)
        {
            Console.Write("P ");
        }
        else if (ladders.Any(l => l.Position == i))
        {
            Console.Write("L ");
        }
        else if (snakes.Any(s => s.Position == i))
        {
            Console.Write("S ");
        }
        else
        {
            Console.Write("* ");
        }

        if (i % 9 == 0)
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

while (player1.Position < board.NumberOfTiles)
{
    DrawBoard();

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
