using Microsoft.AspNetCore.Mvc;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.Plays;


namespace TheatherWebProject.Areas.Admin.Controllers
{
    public class ActorController : AdminController
    {
        private readonly IActorService _actorService;
        private readonly IPlayService _playService;
        private readonly ILogger<ActorController> _logger;

        public ActorController(IActorService actorService, IPlayService playService, ILogger<ActorController> logger)
        {
            _actorService = actorService;
            _playService = playService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new ActorFormModel
            {
                AllPlaysDropDown = await _playService.GetAllPlayServiceModelAsync()
            };

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
            try
            {
                var actorId = await _actorService.CreateAsync(model);
                return RedirectToAction("Details", "Actor", new { area = "", id = actorId });
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError($"Error occurred in Admin/ActorController Add Get - {ex.Message}");
                return BadRequest("An error occurred while processing your request.");
            }

        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            bool actorExists = await _actorService.ExistsByIdAsync(id);

            if (!actorExists)
            {
                _logger.LogWarning("Admin/ActorController Edit Get- Actor not found for ID: {ActorId}", id);
                return NotFound();
            }
            try
            {
                Task<ActorFormModel> getActorTask = _actorService.GetActorFromModelAsync(id);

                Task<List<PlayServiceModel>> getAllPlaysTask = _playService.GetAllPlayServiceModelAsync();

                await Task.WhenAll(getActorTask, getAllPlaysTask);

                ActorFormModel model = getActorTask.Result;
                model.AllPlaysDropDown = getAllPlaysTask.Result;

                return View(model);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError($"Error occurred in Admin/ActorController Edit Get for ID: ActorId: {id} - {ex.Message}");
                return BadRequest("An error occurred while processing your request.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred in Admin/ActorController Edit Get for ID: ActorId: {id} - {ex.Message}");
                return BadRequest("An error occurred while processing your request.");
            }
        }
        [HttpPost]
        public async Task<IActionResult> Edit(int id, ActorFormModel model)
        {
            
            bool actorExists = await _actorService.ExistsByIdAsync(id);

            if (!actorExists)
            {
                _logger.LogWarning("Admin/ActorController Edit Post - Actor not found for ID: {ActorId}", id);
                return NotFound();
            }
            if (!ModelState.IsValid)
            {
                return RedirectToAction(nameof(Edit), new { id });
            }

            try
            {
                await _actorService.EditAsync(id, model);
            }
            catch (InvalidOperationException ex)
            {
                _logger.LogError($"Error occurred in Admin/ActorController Edit Post for ID: ActorId: {id} - {ex.Message}");
                return BadRequest("An error occurred while processing your request.");
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error occurred in Admin/ActorController Edit Post for ID: ActorId: {id} - {ex.Message}");
                return BadRequest("An error occurred while processing your request.");
            }

            return RedirectToAction("Details", "Actor", new { area = "", id });
        }


    }
}
