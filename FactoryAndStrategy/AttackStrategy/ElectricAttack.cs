namespace FactoryAndStrategy.AttackStrategy;

public class ElectricAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used electric bolt.");
    }
}