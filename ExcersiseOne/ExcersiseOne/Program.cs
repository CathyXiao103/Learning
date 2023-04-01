using ExcersiseOne;

var dog = new Dog();
var cat = new Cat();
var cow = new Cow("Mia", "Brown");

dog.Name = "Rex";
cat.Name = "Mittens";
cow.Name = "Bos";

dog.Color = "Red";
cat.Color = "Black";
cow.Color = "White";

var animals = new List<Animal>();
animals.Add(dog);
animals.Add(cat);
animals.Add(cow);



foreach (var animal in animals)
{
    Console.WriteLine($"animal name is: {animal.Name}");
    Console.WriteLine(animal.Speak());

}