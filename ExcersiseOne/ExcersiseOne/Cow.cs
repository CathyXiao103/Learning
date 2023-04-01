using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcersiseOne;
public class Cow:Animal
{
    public Cow(string sound,string color)
    {
        Sound = sound;
        Color = color;
        
    }
    public string CowColour()
    {
        return $"{Name} is {Color}";
    }

}
