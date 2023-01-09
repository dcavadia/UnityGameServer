using Microsoft.AspNetCore.Mvc;
using Server.Services;
using SharedLibrary;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HeroController : ControllerBase
    {
        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService) {
            _heroService = heroService;

        }

        [HttpGet]
        public Hero Get([FromQuery]int id )
        {
            _heroService.DoSomething();
            var hero = new Hero() {Id=id};
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
