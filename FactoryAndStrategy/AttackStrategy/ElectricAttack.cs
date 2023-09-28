namespace FactoryAndStrategy.AttackStrategy;

public class ElectricAttack : IPokemonAttackStrategy
{
    public string Attack(string attackerName)
    {
        return $"{attackerName} used electric bolt.";
    }
}