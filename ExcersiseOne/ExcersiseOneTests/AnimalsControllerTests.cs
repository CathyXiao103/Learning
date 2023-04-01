using ExcersiseOne;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseOneTests;

public class AnimalsControllerTests
{
    [Test]
    public void AddAnimal_Test()
    {
        var animalController = new AnimalsController();
        var cow = new Animal(); 
        var cat = new Animal();
        cow.Name = "Mia";
        cat.Name = "Kitty";
        animalController.AddAnimal(cow);
        animalController.AddAnimal(cat);

        foreach(var animal in animalController.GetAnimals())
        //foreach (var animal in animalController.animals)
        {
            Console.WriteLine($"animal's name is {animal.Name}");
        }

        Assert.AreEqual(2, animalController.GetAnimals().Count);
        Console.Write($"Animal number is {animalController.GetAnimals().Count}");
    }

    [Test]
    public void RemoveAnimal_Test()
    {
        var animalController = new AnimalsController();
        var cow = new Animal();
        animalController.AddAnimal(cow);
        Console.Write($"Before remove, Animal number is {animalController.GetAnimals().Count}\n");
        animalController.RemoveAnimal(cow);

        Assert.AreEqual(0, animalController.GetAnimals().Count);
        Console.Write($"After remove,Animal number is {animalController.GetAnimals().Count}");
    }

    [Test]
    public void AnimalSpeak_Test()
    {
        var animalController = new AnimalsController();
        var cow = new Cow("Moo","Brown");
        cow.Name = "Mia";
        var tempSpeak = animalController.MakeAnimalSpeak(cow);
        Console.WriteLine($"{tempSpeak}");
        Assert.AreEqual("Mia says Moo", tempSpeak);
      
    }

}
