using System.Runtime.InteropServices.ComTypes;
using SnakeAndLadderGame;
using System.Xml.Linq;

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
            var sut = result.ElementAt(2);
           
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
    }
}