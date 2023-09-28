using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy;

public interface IPokemon
{
    public string Attack();
    void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy);
}