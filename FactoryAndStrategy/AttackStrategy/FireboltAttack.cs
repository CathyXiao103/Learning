namespace FactoryAndStrategy.AttackStrategy;

public class FireboltAttack : IPokemonAttackStrategy
{
    public string Attack(string attackerName)
    {
        return $"{attackerName} used Firebolt!";
    }

    public void Attack()
    {
        Console.WriteLine("FireboltAttack used!");
    }
}