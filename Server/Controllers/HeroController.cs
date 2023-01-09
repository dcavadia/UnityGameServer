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
        private readonly GameDbContext _context;

        public HeroController(IHeroService playerService, GameDbContext context)
        {
            _heroService = playerService;
            _context = context;
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
