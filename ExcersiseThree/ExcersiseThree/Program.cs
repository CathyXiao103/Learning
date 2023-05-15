using ExcersiseThree;
using SomeLegacyLib;

var dog = new Dog("Felix", "woof", "brown");
var legacyPikachu = new Pikachu("Pikachu");
var pikachu = new LegacyAnimalAdapter(legacyPikachu);
var animals = new List<Animal>
{
    dog,
    pikachu
};

foreach (var animal in animals)
{
    if (animal == dog)
    {
        animal.Speak();
        animal.Colour();
    }
    else
    {
        animal.Speak();
        animal.Colour();
    }
}