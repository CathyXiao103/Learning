namespace FactoryAndStrategy.AttackStrategy;

public class WaterblastAttack : IPokemonAttackStrategy
{
    public string Attack(string attackerName)
    {
        return $"{attackerName} used WaterblastAttack!";
    }

    public void Attack()
    {
        Console.WriteLine("WaterblastAttack used!");
    }
}