using ExcersiseThree;
using SomeLegacyLib;

namespace ExcersiseThreeTest;

public class BulbasaurTest
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Bulbasaur_Test()
    {
        //Arrange
        var legacyBulbasaur = new Bulbasaur("Bulbasaur");

        //Act
        var bulbasaur = new LegacyAnimalAdapter(legacyBulbasaur);
        var bulbasaurSpeak = bulbasaur.Speak();
        var bulbasaurColour = bulbasaur.Colour();

        //Assert
        Assert.AreEqual("Bulbasaur says buhl buh saw!", bulbasaurSpeak);
        Assert.AreEqual("Bulbasaur is Green!", bulbasaurColour);

    }
}
