namespace ExcersiseOne;

public class Animal
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Age { get; set; }
    public string Type { get; set; }
    public string Sound { get; set; }

    public string Speak()
    {
        return $"{Name} says {Sound}";
    }
    

}