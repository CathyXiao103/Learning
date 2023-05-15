using ExcersiseThree;
using NUnit.Framework.Constraints;
using SomeLegacyLib;
namespace ExcersiseThreeTest;
public class LegacyAnimalAdapterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void LegacyAnimalAdapter_TestSpeak()
    {
        //Arrange
        var legacyPikachu = new Pikachu("Pikachu");
        var pikachu = new LegacyAnimalAdapter(legacyPikachu);
        
        //Act
        var result = pikachu.Speak();

        //Assert
        Assert.AreEqual("Pikachu says Pika-choo!", result);
    }

    [Test]
    public void LegacyAnimalAdapter_TestColor()
    {

        //Arrange
        var legacyBulbasaur = new Bulbasaur("Bulbasaur");
        var bulbasaur = new LegacyAnimalAdapter(legacyBulbasaur);

        //Act
        var result = bulbasaur.Colour();

        //Assert
        Assert.AreEqual("Bulbasaur is Green!", result);

    }


}