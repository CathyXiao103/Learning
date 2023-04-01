using ExcersiseOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseOneTests
{
    internal class CatTests
    {
        [Test]
        public void Cat_Returns_Sound()
        {
            //Arrange
            var animal = new Cat();
            animal.Name = "Mittens";

            //Act
            var result = animal.Speak();

            //Assert
            Assert.AreEqual("Mittens says Meow", result);
        }
    }
}
