using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StratGame.Model;

namespace StratGame.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : Controller
    {
        //GET: Map
        [HttpGet("getmap")]
        public ActionResult<Map> GetMap()
        {
            return Json(Game.BasicMap);
        }

        //POST: Move
        [HttpPost("move")]
        public void Move([FromBody] Command c)
        {
            if(c.Id == 0) Game.Move(Game.Soldier1, c.X, c.Y);
            else Game.Move(Game.Soldier2, c.X, c.Y);
        }
    }
}