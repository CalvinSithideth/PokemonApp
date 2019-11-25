using PokemonAppAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PokemonApp.Models
{
    /// <summary>
    /// A ViewModel class for displaying a single
    /// Pokemon's Pokedex entry
    /// </summary>
    public class SinglePokedexEntry
    {
        public int PokedexId { get; set; }

        public string ProfileImageUrl { get; set; }

        public string Name { get; set; }

        /// <summary>
        /// This is the height in decimeters
        /// </summary>
        public int Height { get; set; }

        /// <summary>
        /// This is the weight in hectograms
        /// </summary>
        public int Weight { get; set; }

        /// <summary>
        /// List of the Pokemon's ability names
        /// </summary>
        public List<string> Abilities { get; set; }
    }
}
