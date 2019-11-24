using PokemonAppAPI;
using System;
using System.Threading.Tasks;

namespace PokeApiTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            PokemonClient client = new PokemonClient();
            PokemonResponse result = await client.GetPokemon(1);

            Console.WriteLine($"Name: {result.name}");
            Console.WriteLine($"Weight: {result.weight}");

            Console.WriteLine("\n\n" + "Abilities" + "\n");
            foreach (var ability in result.abilities)
            {
                Console.WriteLine(ability.ability.name);
                Console.WriteLine($"More information at: {ability.ability.url}");
            }

            Console.ReadKey();
        }
    }
}
