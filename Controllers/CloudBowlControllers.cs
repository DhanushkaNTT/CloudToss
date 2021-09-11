using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cloudbowl.samples.dotnet.Controllers
{
    [ApiController]
    [Route("")]
    public class CloudBowlController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Let the battle begin!");
        }

        [HttpPost]
        public string PostArenaUpdate(ArenaUpdate arenaUpdate)
        {
            Console.WriteLine(arenaUpdate);
            try
            {
               /* 
                arenaUpdate.arena.state.TryGetValue("dhanushka",out PlayerState ps);
                if(ps!=null){
                    ps.score=ps.score+10;
                    ps.wasHit=false;
                }
                */

                string[] commands = new string[] { "F", "R", "L", "T" };
                int i = new Random().Next(4);

                return commands[i];
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}