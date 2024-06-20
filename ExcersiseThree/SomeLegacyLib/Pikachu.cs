namespace SomeLegacyLib;
public class Pikachu:ILegacyAnimal
{
    protected string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }

    public Pikachu(string name)
    {
        Name = name;
    }

    public string LegacySpeakMethod()
    {
        return $"{Name} says Pika-choo!";
    }
    public string LegacyColourMethod()
    {
        return $"{Name} is yellow!";
    }
}
