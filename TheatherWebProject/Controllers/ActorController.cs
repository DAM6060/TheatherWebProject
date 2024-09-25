using Microsoft.AspNetCore.Mvc;
using TheatherWebProject.Core.Contracts;

namespace TheatherWebProject.Controllers
{
	public class ActorController : Controller
	{
		
		private readonly IActorService _actorService;
		private readonly IPlayService _playService;

		public ActorController(
            
            IActorService actorService,
            IPlayService playService)
        {
           
            _actorService = actorService;
            _playService = playService;
        }

        public async Task<IActionResult> Index()
		{
			var actors = await _actorService.GetAllAsync();

			return View(actors);
		}
	}
}
