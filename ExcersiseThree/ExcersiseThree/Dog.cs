using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseThree;

public class Dog:Animal
{
    public Dog(string name,string sound,string color)
    {
        this.Name=name;
        this.Sound=sound;
        this.Color=color;
        //"this" can also be omitted, since Name is public in parent class Animal.
        //using "this" explicitly can help make the code more self-documenting and clarify that you are accessing the property of the current object.
    }
}
