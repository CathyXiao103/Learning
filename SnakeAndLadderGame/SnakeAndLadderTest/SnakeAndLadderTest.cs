using NUnit.Framework;
using SnakeAndLadderGame;
namespace SnakeAndLadderTest
{
    public class SnakeAndLadderTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DiceRollTest()
        {
            //Arrange
            var su = new SnakeAndLadder();
            //Act
            int diceResult = su.DiceRoll();
            //Assert
            Assert.IsTrue(diceResult >= 1 && diceResult <= 6, "Dice roll result is incorrect.");

        }

    }
}