namespace FactoryAndStrategy.AttackStrategy;

public class ThunderboltAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used ThunderboltAttack!");
    }

    public void Attack()
    {
        Console.WriteLine("ThunderboltAttack used!");
    }
}