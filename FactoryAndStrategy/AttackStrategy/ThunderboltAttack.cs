namespace FactoryAndStrategy.AttackStrategy;

public class ThunderboltAttack : IPokemonAttackStrategy
{
    public string Attack(string attackerName)
    {
       return $"{attackerName} used ThunderboltAttack!";
    }

    public void Attack()
    {
        Console.WriteLine("ThunderboltAttack used!");
    }
}