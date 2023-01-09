using Microsoft.AspNetCore.Mvc;
using SharedLibrary;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        [HttpGet]
        public Hero Get()
        {
            var hero = new Hero();
            return hero;
        }    
    }
}
