using ExcersiseOne;

namespace ExcersiseOneTests;

public class AnimalTests
{
    
    [Test]
    public void Animal_Returns_Sound()
    {
        //Arrange
        var animal = new Animal();
        animal.Name =  "Rex";
        animal.Sound = "Woof";

        //Act
        var result = animal.Speak();

        //Assert
        Assert.AreEqual("Rex says Woof", result);
    }
}