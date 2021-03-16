using System;
using Microsoft.AspNetCore.Mvc;

namespace ApiLabb.Controllers
{
    [ApiController]
    [Route("api/pokemon")]
    public class PokemonController: ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok("HEj"); 
        }
    }
}
