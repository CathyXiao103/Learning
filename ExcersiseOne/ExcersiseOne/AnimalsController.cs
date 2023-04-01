using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ExcersiseOne;

public class AnimalsController
{
    private List<Animal> animals;

    public AnimalsController()
    {
        animals = new List<Animal>();
    }
    public List<Animal> GetAnimals()
    {
        return animals;
    }
    //public List<Animal> animals;


    public void AddAnimal(Animal animal)
    {
       animals.Add(animal);

    }

    public void RemoveAnimal(Animal animal)
    {
        animals.Remove(animal);
    }

    public string MakeAnimalSpeak(Animal animal)
    {
        return $"{animal.Name} says {animal.Sound}";

    }
        
}
