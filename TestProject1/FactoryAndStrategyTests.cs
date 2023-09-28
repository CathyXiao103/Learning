using FactoryAndStrategy.AttackStrategy;
using FactoryAndStrategy.Pokemons;

namespace FactoryAndStrategyTest;

public class FactoryAndStrategyTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void PikachuUseThunderboltAttack()
    {
        //Arrange
        var expected = "Max used ThunderboltAttack!";
        var pikachu = PokemonFactory.CreatePokemon("Max", "Pikachu");
        //Act
        var acturalAttack = pikachu.Attack();
        //Assert
        Assert.AreEqual(expected, acturalAttack);
    }

    [Test]
    public void SetNewStrategy()
    {
        //Arrange
        var pikachu = PokemonFactory.CreatePokemon("Max", "Pikachu");
        pikachu.SetNewStrategy(new FireboltAttack());
        //Act
        var attack = pikachu.Attack();
        //Assert
        Assert.AreEqual("Max used Firebolt!", attack);
    }
}