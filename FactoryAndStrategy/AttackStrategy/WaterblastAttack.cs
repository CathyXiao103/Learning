namespace FactoryAndStrategy.AttackStrategy;

public class WaterblastAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used WaterblastAttack!");
    }

    public void Attack()
    {
        Console.WriteLine("WaterblastAttack used!");
    }
}