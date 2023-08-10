using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy.Pokemons;

internal class Balbasaur : IPokemon
{
    private IPokemonAttackStrategy _attackStrategy;
    private readonly string _name;

    public Balbasaur(string name, IPokemonAttackStrategy attackStrategy)
    {
        _name = name;
        _attackStrategy = attackStrategy;
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