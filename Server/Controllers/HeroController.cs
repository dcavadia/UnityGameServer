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

        [HttpPost]
        public Hero Post(Hero hero)
        {
            Console.WriteLine("Player has been added to the DB");
            return hero;
        }
    }
}
