using Microsoft.AspNetCore.Mvc;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Core.Models.Actors;


namespace TheatherWebProject.Areas.Admin.Controllers
{
    public class ActorController : AdminController
    {
        private readonly IActorService _actorService;
        private readonly IPlayService _playService;

        public ActorController(IActorService actorService, IPlayService playService)
        {
            _actorService = actorService;
            _playService = playService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ActorFormModel();
            model.AllPlaysDropDown = await _playService.GetAllPlayServiceModelAsync();

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Add(ActorFormModel model)
        {
            if (!ModelState.IsValid) {
                //return RedirectToAction(nameof(Details), new { actorId });
                //uncomment when Details action is implemented
                var newModel = new ActorFormModel();
                newModel.AllPlaysDropDown = await _playService.GetAllPlayServiceModelAsync();

                return RedirectToAction(nameof(Add), newModel);
            }

            var actorId = await _actorService.CreateAsync(model);
            return RedirectToAction("Details", "Actor", new { area = "", id = actorId });
        }
    }
}
