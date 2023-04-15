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
        var legacyBulbasaur = new Bulbasaur("Bulbasaur");
        var bulbasaur = new LegacyAnimalAdapter(legacyBulbasaur);
        Assert.AreEqual("Bulbasaur says buhl buh saw!", bulbasaur.Speak());
        Assert.AreEqual("Bulbasaur is Green!", bulbasaur.Colour());

    }
}
