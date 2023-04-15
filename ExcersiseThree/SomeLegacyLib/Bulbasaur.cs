namespace SomeLegacyLib;
public class Bulbasaur:ILegacyAnimal
{
    public Bulbasaur(string name)
    {
        this.Name = name;
    }
    protected string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
    public string LegacySpeakMethod()
    {
        return $"{Name} says buhl buh saw!";
    }
    public new string LegacyColourMethod()
    {
        return $"{Name} is Green!";
    }
}
