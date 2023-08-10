using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy;

public interface IPokemon
{
    void Attack();
    void SetNewStrategy(IPokemonAttackStrategy newAttackStrategy);
}