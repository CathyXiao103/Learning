using FactoryAndStrategy.AttackStrategy;

namespace FactoryAndStrategy.Pokemons;

public class PokemonFactory
{
    public static IPokemon CreatePokemon(string name, string type)
    {
        switch (type)
        {
            case "Charmander":
                return new Charmander(name);
            case "Squirtle":
                return new Squirtle(name, new WaterblastAttack());
            case "Pikachu":
                return new Pikachu(name, new ThunderboltAttack());
            case "Balbasaur":
                return new Balbasaur(name, new ElectricAttack());
            default:
                throw new ArgumentException($"{type} is invalid type");
        }
    }
}