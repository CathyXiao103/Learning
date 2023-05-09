using ExcersiseOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseOneTests;

public class CowTests
{
    
    [Test]
    public void Cow_Color_Test()
    {
        //Arrange
        Cow cow = new Cow("Mia","Brown");

        //Act
        cow.Name = "Mia";
        var CowColor = cow.CowColour();
        var expectedCowColor = "Mia is Brown";

        //Assert
        Assert.AreEqual(expectedCowColor, CowColor);

    }

    [Test]
    public void Cow_Speak_Test()
    {
        //Arrange
        Cow cow = new Cow("Moo", "Brown");
        cow.Name = "Mia";

        //Act
        var expectedcowSound = "Mia says Moo";
        var cowSpeak = cow.Speak();

        //Assert
        Assert.AreEqual(expectedcowSound,cowSpeak);
    }
        
}
