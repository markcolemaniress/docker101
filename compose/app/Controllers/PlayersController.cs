using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using app.Models;
using Microsoft.AspNetCore.Mvc;

namespace app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET api/players
        [HttpGet]
        public ActionResult<IEnumerable<Player>> Get()
        {
            Console.WriteLine("Api.PlayersController.Get() called");
            return DataManager.GetPlayers().ToArray();
        }

        // GET api/players/5
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            Console.WriteLine("Api.PlayersController.Get(id) called");
            return DataManager.GetPlayerDetails(id);
        }
    }
}
