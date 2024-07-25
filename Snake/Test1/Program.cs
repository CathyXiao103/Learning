using Raylib_cs;
using System.Numerics;
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
    new Ladder() {Position = 60,TargetPosition = 67}
};

var snakes = new List<Snake>()
{
    new Snake(){Position = 16,TargetPosition = 6},
    new Snake(){Position = 18,TargetPosition = 9},
    new Snake(){Position = 31,TargetPosition = 16},
    new Snake(){Position = 38,TargetPosition = 1},
    new Snake(){Position = 52,TargetPosition = 26},
    new Snake(){Position = 68,TargetPosition = 18},
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
bool CheckForGameEnd()
{
    if (player1.Position >= board.NumberOfTiles)
    {
        Console.WriteLine("Game Over");
        return true;
    }

    return false;
}
const int screenWidth = 720;
const int screenHeight = 720;
Raylib.InitWindow(screenWidth, screenHeight, "Snake and Ladder");
Raylib.SetTargetFPS(60);
void DrawBoard()
{

    int rows = 8;
    int cols = 9;
    int cellSize = 80; // Size of each cell in pixels
    for (int y = 0; y < rows; y++)
    {
        for (int x = 0; x < cols; x++)
        {
            int posX = x * cellSize;
            int posY = y * cellSize;

            // Draw cell
            Color cellColor = Color.LightGray;
            Raylib.DrawRectangle(posX, posY, cellSize, cellSize, cellColor);
            Raylib.DrawRectangleLines(posX, posY, cellSize, cellSize, Color.Black);

            // Calculate cell number
            int cellNumber = (cols * y) + ((y % 2 == 0) ? x : (cols - 1 - x)) + 1;

            // Draw cell number
            Raylib.DrawText(cellNumber.ToString(), posX + 10, posY + 10, 20, Color.Black);

            // Draw player
            if (cellNumber == player1.Position)
            {
                Raylib.DrawCircle(posX + cellSize / 2, posY + cellSize / 2, cellSize / 4, Color.Red);
            }

            // Draw ladders
            if (ladders.Any(l => l.Position == cellNumber))
            {
                Raylib.DrawText("L", posX + cellSize / 2, posY + cellSize / 2, 20, Color.Green);
            }

            // Draw snakes
            if (snakes.Any(s => s.Position == cellNumber))
            {
                Raylib.DrawText("S", posX + cellSize / 2, posY + cellSize / 2, 20, Color.Blue);
            }
        }
    }

    Console.WriteLine();
}

while (!CheckForGameEnd())
{
   
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.RayWhite);
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
    Raylib.DrawText($"Player rolled a {diceRoll}", 10, screenHeight - 60, 20, Color.Black);
    Raylib.DrawText($"Player moved to position {player1.Position}", 10, screenHeight - 30, 20, Color.Black);
    Raylib.EndDrawing();
    Thread.Sleep(1000);
}

