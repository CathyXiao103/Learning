using System.Runtime.InteropServices.ComTypes;
using SnakeAndLadderGame;
using System.Xml.Linq;
using NUnit.Framework.Internal;

namespace SnakeAndLaddersTest
{
    public class SnakeAndLaddersGameTests
    {
        //private SnakeAndLadder game;
        //[SetUp]
        //public void Setup()
        //{
        //    game = new SnakeAndLadder();
        //}
        
        private SnakeLadderMap game;

        [SetUp]
        public void Setup()
        {
            game = new SnakeLadderMap();
        }
    

        [Test]
        public void GameBoardExistsWith72Tiles()
        {
            //Arrange
            var expectedTiles = 72;
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            
            //Act
            var result = snakeAndLadderGame.InitializeMap();
            //Assert
        
            Assert.AreEqual(expectedTiles, result.Count());
        }

        [Test]
        public void WhenGameInitializedMapIsReadyWithSnakesAndSnakesInTheCorrectPositions()
        {
            //Arrange
            var expectedTileType = TileType.Snake;
            var expectedPositionToTakeTo = 3;
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            
            //Act
            var result = snakeAndLadderGame.InitializeMap();
            var sut = result.ElementAt(7);
           
            //Assert
            Assert.AreEqual(expectedTileType, sut.TileType);
            Assert.AreEqual(expectedPositionToTakeTo, sut.PositionToTakeTo);
        }
        [Test]
        public void WhenGameInitializedMapIsReadyWithLaddersAndLaddersInTheCorrectPositions()
        {
            //Arrange
            var expectedTileType = TileType.Ladder;
            var expectedPositionToTakeTo = 16;
            var snakeAndLadderGame = new SnakeAndLaddersGame();

            //Act
            var result = snakeAndLadderGame.InitializeMap();
            var sut = result.ElementAt(10);

            //Assert
            Assert.AreEqual(expectedTileType, sut.TileType);
            Assert.AreEqual(expectedPositionToTakeTo, sut.PositionToTakeTo);
        }
        [Test]
        public void InitializePlayerWithCorrectStartPosition()
        {
            //arrange
            var expectedPostion = 1;
            var expectedPlayerName = "Player1";
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            

            //Act
            var player = snakeAndLadderGame.InitializePlayer(expectedPlayerName);
            
            //Assert
            Assert.AreEqual(expectedPostion,player.Position);
            //Assert.AreEqual(expectedPlayerName,player.PlayerName);
        }

        [Test]
        public void PlayerCanStartWhenRoll6()
        {
            //arrange
            var diceNumber = 6;
           
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            var player = snakeAndLadderGame.InitializePlayer("Player1");

            //Act
            player.CanPlayerStart(diceNumber);
            
            //Assert
            Assert.IsTrue(player.CanStart);
        } 
        [Test]
        public void PlayerMovesForwardCorrectlyBasedOnDieRoll()
        {
            //Arrange
            var startPosition = 4;
            var diceNumber = 4;
            var expectedPositionAfterMove = 8;
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            var player = snakeAndLadderGame.InitializePlayer("Player1");
            player.CanStart = true;
            player.Position = startPosition;
           
            //Act
            player.Move(diceNumber,snakeAndLadderGame.GameMap);
            
            //Assert
            Assert.AreEqual(expectedPositionAfterMove,player.Position);
        }


        [Test]
        public void PlayerLandsOnSnakeAndMovesDown()
        {
            //Arrange
            var startPosition = 4;
            var diceNumber = 3;
            var expectedPositionAfterMove = 3;
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            var player = snakeAndLadderGame.InitializePlayer("Player1");
            player.CanStart = true;
            player.Position = startPosition;

            //Act
            player.Move(diceNumber, snakeAndLadderGame.GameMap);

            //Assert
            Assert.AreEqual(expectedPositionAfterMove, player.Position);
        }
        
        [Test]
        public void PlayerLandsOnLadderAndMovesUp()
        {
            //Arrange
            var startPosition = 8;
            var diceNumber = 2;
            var expectedPositionAfterMove = 16;
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            var player = snakeAndLadderGame.InitializePlayer("Player1");
            player.CanStart = true;
            player.Position = startPosition;

            //Act
            player.Move(diceNumber, snakeAndLadderGame.GameMap);

            //Assert
            Assert.AreEqual(expectedPositionAfterMove, player.Position);
        }

        [Test]
        public void LastTileIsWinPosition()
        {
            //arrange
            var snakeAndLadderGame = new SnakeAndLaddersGame();
            var player = snakeAndLadderGame.InitializePlayer("Player1");
            player.Position = 72;
            
            //Act
            var isWinner = player.IsWinner(player.Position);
            
            //Assert
            Assert.IsTrue(isWinner);
        }
    }
}