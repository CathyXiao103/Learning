using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy.Pokemons;

internal class Squirtle : IPokemon
{
    private IPokemonAttackStrategy _attackStrategy;
    private readonly string _name;

    public Squirtle(string name, WaterblastAttack waterblastAttack)
    {
        _name = name;
        _attackStrategy = waterblastAttack;
    }

    public string Attack()
    {
       return _attackStrategy.Attack(_name);
    }

    public void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy)
    {
        _attackStrategy = newAttackStrategy;
    }
}