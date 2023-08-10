// See https://aka.ms/new-console-template for more information

using FactoryAndStrategy.AttackStrategy;
using FactoryAndStrategy.Pokemons;

Console.WriteLine("Hello, World!");
var pikachu = PokemonFactory.CreatePokemon("Max", "Pikachu");
pikachu.Attack();

pikachu.SetNewStrategy(new FireboltAttack());
pikachu.Attack();

pikachu.SetNewStrategy(new WaterblastAttack());
pikachu.Attack();

pikachu.SetNewStrategy(new ThunderboltAttack());
pikachu.Attack();

var charmander = PokemonFactory.CreatePokemon("FireZ", "Charmander");
charmander.Attack();
charmander.SetNewStrategy(new WaterblastAttack());
charmander.Attack();


var squirtle = PokemonFactory.CreatePokemon("Mia", "Squirtle");
squirtle.Attack();

var balbasaur = PokemonFactory.CreatePokemon("Tim", "Balbasaur");
balbasaur.Attack();

var invalidType = PokemonFactory.CreatePokemon("T-Rex", "tetew");
invalidType.Attack();