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
    public void Pikuchu_Test()
    {
        var dog = new Dog("Felix","woof","brown");
        var legacyPikachu = new Pikachu("Pikachu");
        var pikachu = new LegacyAnimalAdapter(legacyPikachu);
        var animals = new List<Animal>
        {
            dog,
            pikachu
        };

        foreach (var animal in animals)
        {
            //Console.WriteLine($"animal name is: {animal.Name}");
            if (animal == dog)
            {
                Console.WriteLine(animal.Speak());
                Console.WriteLine(animal.Colour());
                Assert.AreEqual("Felix says woof!", animal.Speak());
                Assert.AreEqual("Felix is brown", animal.Colour());
            }
            else
            {
                Console.WriteLine(animal.Speak());
                Console.WriteLine(animal.Colour());
                Assert.AreEqual("Pikachu says Pika-choo!", animal.Speak());
                Assert.AreEqual("Pikachu is yellow!", animal.Colour());
            }

            

        }
    }
   
}