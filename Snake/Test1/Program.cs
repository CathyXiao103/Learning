// See https://aka.ms/new-console-template for more information
using SnakeAndLadderGame;

var player1 = new Player(){ Position = 0};

var board = new GameBoard(){NumberOfTiles = 72};

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