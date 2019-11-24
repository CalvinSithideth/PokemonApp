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
        public IActionResult Index()
        {
            //PokemonClient client = new PokemonClient();
            //PokemonResponse data = client.GetPokemonByIdOrName(1, null);
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
