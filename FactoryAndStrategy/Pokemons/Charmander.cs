using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy.Pokemons;

public class Charmander : IPokemon
{
    private IPokemonAttackStrategy _attackStrategy;
    private readonly string _name;

    public Charmander(string name)
    {
        _name = name;
        _attackStrategy = new FireboltAttack();
    }

    public void Attack()
    {
        _attackStrategy.Attack(_name);
    }

    public void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy)
    {
        _attackStrategy = newAttackStrategy;
    }
}