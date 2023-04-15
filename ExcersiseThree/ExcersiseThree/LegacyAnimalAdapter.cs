using SomeLegacyLib;

namespace ExcersiseThree;

public class LegacyAnimalAdapter:Animal
{
    private ILegacyAnimal _legacyAnimal;
    public LegacyAnimalAdapter(ILegacyAnimal legacyAnimal)
    {
        _legacyAnimal = legacyAnimal;
    }
    public override string Speak()
    {
        return _legacyAnimal.LegacySpeakMethod();
    }
    public override string Colour()
    {
        return _legacyAnimal.LegacyColourMethod();
    }
}
