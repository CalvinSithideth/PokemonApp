using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PokemonAppAPI
{
    public class PokemonClient
    {
        private static readonly HttpClient _client;

        static PokemonClient()
        {
            _client = new HttpClient();
            // Must end with a forward slash
            _client.BaseAddress = new Uri("https://pokeapi.co/api/v2/");
        }

        /// <summary>
        /// Returns a single Pokemon's data using Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<PokemonResponse> GetPokemon(int id)
        {
            return await GetPokemon(id.ToString());
        }

        /// <summary>
        /// Returns a single Pokemons data using name.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public async Task<PokemonResponse> GetPokemon(string name)
        {
            HttpResponseMessage response = await _client.GetAsync($"pokemon/{name}");
            if (response.IsSuccessStatusCode)
            {
                string data = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<PokemonResponse>(data);
            }
            else
            {
                throw new Exception("Call was not successful.");
            }
        }
    }
}
