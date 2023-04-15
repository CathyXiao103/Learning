using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseThree;

public abstract class Animal
//The abstract modifier in C# indicates that a class cannot be instantiated directly and must be derived from by other classes. 
{
    public string Name { get; set; }    
    public string Color { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }

    public string Sound { get; set; }
    public virtual string Speak()
    //virtual means can be overridden by derived classes
    {
        return $"{Name} says {Sound}!";
    }
    public virtual string Colour()
    {
        return $"{Name} is {Color}";
    }
}
