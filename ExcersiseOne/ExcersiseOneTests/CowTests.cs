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
        Cow cow = new Cow("Mia","Brown");
        cow.Name = "Mia";
        var cowColor = "Mia is Brown";
        Assert.AreEqual(cow.CowColour(), cowColor);

    }

    [Test]
    public void Cow_Speak_Test()
    {
        Cow cow = new Cow("Moo", "Brown");
        cow.Name = "Mia";
        var cowSound = "Mia says Moo";
        Assert.That(cowSound,Is.EqualTo(cow.Speak()));
    }
        
}
