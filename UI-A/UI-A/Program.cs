using System;
using System.Collections.Generic;

class Program
{
    const int BoardSize = 10;
    const int NumCells = BoardSize * BoardSize;
    static Dictionary<int, int> ladders = new Dictionary<int, int>();
    static Dictionary<int, int> snakes = new Dictionary<int, int>();
    static int playerPosition = 1;
    static Random rand = new Random();

    static void Main()
    {
        // Initialize ladders and snakes
        InitializeLaddersAndSnakes();

        while (playerPosition < NumCells)
        {
            // Draw the board
            DrawBoard();

            // Get user input for dice roll
            Console.WriteLine("Press Enter to roll the dice...");
            Console.Out.Flush(); // Ensure the message is printed
            Console.ReadLine();
            int diceRoll = RollDice();
            Console.WriteLine($"You rolled a {diceRoll}");

            // Update player position
            playerPosition += diceRoll;
            if (playerPosition > NumCells)
            {
                playerPosition = NumCells;
            }

            // Check for ladders or snakes
            if (ladders.ContainsKey(playerPosition))
            {
                Console.WriteLine($"You landed on a ladder! Climb up to {ladders[playerPosition]}");
                playerPosition = ladders[playerPosition];
            }
            else if (snakes.ContainsKey(playerPosition))
            {
                Console.WriteLine($"You landed on a snake! Slide down to {snakes[playerPosition]}");
                playerPosition = snakes[playerPosition];
            }

            // Print current position
            Console.WriteLine($"Your current position is {playerPosition}");

            // Check if the player has won
            if (playerPosition == NumCells)
            {
                DrawBoard();
                Console.WriteLine("Congratulations! You have reached the end of the board and won the game!");
                break;
            }
        }
    }

    static void InitializeLaddersAndSnakes()
    {
        // Example ladders: Start -> End
        ladders[3] = 22;
        ladders[5] = 8;
        ladders[11] = 26;
        ladders[20] = 29;

        // Example snakes: Start -> End
        snakes[17] = 4;
        snakes[19] = 7;
        snakes[21] = 9;
        snakes[27] = 1;
    }

    static void DrawBoard()
    {
        Console.Clear();
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                int cellNumber = NumCells - (i * BoardSize + j);
                if (i % 2 == 1)
                {
                    cellNumber = NumCells - ((i + 1) * BoardSize - j - 1);
                }

                string cellDisplay = " ■ ";
                if (cellNumber == playerPosition)
                {
                    cellDisplay = " P ";
                }
                else if (ladders.ContainsKey(cellNumber))
                {
                    cellDisplay = " L ";
                }
                else if (snakes.ContainsKey(cellNumber))
                {
                    cellDisplay = " S ";
                }

                Console.Write(cellDisplay);
            }
            Console.WriteLine();
        }
    }

    static int RollDice()
    {
        return rand.Next(1, 7); // Dice rolls between 1 and 6
    }
}