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
            return DataManager.GetPlayers().ToArray();
        }

        // GET api/players/5
        [HttpGet("{id}")]
        public ActionResult<Player> Get(int id)
        {
            return DataManager.GetPlayerDetails(id);
        }
    }
}
