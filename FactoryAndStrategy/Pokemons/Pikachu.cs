using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy.Pokemons;


public class Pikachu:IPokemon
{
    string _name;
    IPokemonAttackStrategy _attackStrategy;

    public Pikachu(string name, IPokemonAttackStrategy attackStrategy)
    {
        _name = name;
        _attackStrategy = attackStrategy;
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

