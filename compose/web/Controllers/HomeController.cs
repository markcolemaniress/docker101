using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using web.Models;

namespace web.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            IEnumerable<Player> players = await ApiManager.GetPlayers();
            return View(players);
        }
    }
}
