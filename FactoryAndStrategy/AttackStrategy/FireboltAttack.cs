namespace FactoryAndStrategy.AttackStrategy;

public class FireboltAttack : IPokemonAttackStrategy
{
    public void Attack(string attackerName)
    {
        Console.WriteLine($"{attackerName} used Firebolt!");
    }

    public void Attack()
    {
        Console.WriteLine("FireboltAttack used!");
    }
}