using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PokemonApp.Models;
using PokemonAppAPI;

namespace PokemonApp.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index(int? id)
        {
            // If no PokemonID is passed in,
            // default to the first pokemon
            int pokemonId = id ?? 1;
            PokemonClient client = new PokemonClient();
            PokemonResponse response = await client.GetPokemonAsync(pokemonId);

            var pokemon = new SinglePokedexEntry
            {
                PokedexId = response.id,
                Weight = response.weight,
                Height = response.height,
                ProfileImageUrl = response.sprites.front_default,
                Name = response.name,
                //Abilities = new List<Ability>(response.abilities)
                Abilities = new List<string>()
            };
            foreach (var currAbility in response.abilities)
            {
                pokemon.Abilities.Add(currAbility.ability.name);
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
