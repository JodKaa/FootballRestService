using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FootballRestService.Managers;

namespace FootballRestService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlayersController : ControllerBase
    {
        // GET: api/<PlayersController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return PlayerManager.GetAllPlayers();
        }

        // GET api/<PlayersController>/5
        [HttpGet("{id}")]
        public ActionResult<FootballPlayer> Get(int id)
        {
            return PlayerManager.GetById(id);
        }

        // POST api/<PlayersController>
        [HttpPost]
        public FootballPlayer Post([FromBody] FootballPlayer value)
        {
            return PlayerManager.AddNewPlayer(value);
        }

        // PUT api/<PlayersController>/5
        [HttpPut("{id}")]
        public FootballPlayer Put(int id, [FromBody] FootballPlayer value)
        {
            return PlayerManager.UpdateItem(id, value);
        }

        // DELETE api/<PlayersController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            return PlayerManager.DeletePlayer(id);
        }
    }
}
