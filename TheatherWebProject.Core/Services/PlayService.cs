using Microsoft.EntityFrameworkCore;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.Plays;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Core.Services
{
    public class PlayService : IPlayService
    {
        private readonly IRepository _repository;

        public PlayService(IRepository repository)
        {
            _repository = repository;
        }
        public async Task<int> CreateAsync(PlayFormModel model)
        {
            if (model != null)
            {
                var play = new Play
                {
                    Title = model.Title,
                    Genre = model.Genre,
                    Description = model.Description,
                    Location = model.Location,
                    DateAndTime = model.DateAndTime,
                    TicketURL = model.TicketURL,
                    Town = model.Town,
                    PlayImagesURLs = new List<string>(),
                    PlayVideosURLs = new List<string>(),
             
                };
                foreach (var url in model.ImagesURLs)
                {
                    play.PlayImagesURLs.Add(url);
                }
                foreach (var url in model.VideosURLs)
                {
                    play.PlayVideosURLs.Add(url);
                }
                
                await _repository.AddAsync(play);
                await _repository.SaveChangesAsync();

				AddActorsToPlay(play.Id, model.ActorsIds);

				await _repository.SaveChangesAsync();


                return play.Id;
            }
            else
            {
                throw new InvalidOperationException("Model is null");
            }
        }

        public async Task DeleteAsync(int playId)
        {
            await _repository.All<ActorPlay>()
                .Where(ap => ap.PlayId == playId)
                .ForEachAsync(ap => _repository.DeleteAsync<ActorPlay>(playId));

            await _repository.DeleteAsync<Play>(playId);
            await _repository.SaveChangesAsync();
				
        }

        public async Task EditAsync(int playId, PlayFormModel model)
        {
            var play = _repository.All<Play>()
				.Include(p => p.ActorsPlays)
				.FirstOrDefault(p => p.Id == playId);

            if (play != null)
            {
                play.Title = model.Title;
                play.Genre = model.Genre;
                play.Description = model.Description;
                play.Location = model.Location;
                play.DateAndTime = model.DateAndTime;
                play.TicketURL = model.TicketURL;
                play.Town = model.Town;
                play.PlayImagesURLs = model.ImagesURLs;
                play.PlayVideosURLs = model.VideosURLs;
                play.Town = model.Town;

                play.ActorsPlays.Clear();
				await _repository.SaveChangesAsync();

				AddActorsToPlay(playId, model.ActorsIds);

                await _repository.SaveChangesAsync();
            }
            else
            {
				throw new InvalidOperationException("Play not found");
			}
        }

        public Task<bool> ExistsByIdAsync(int playId)
        {
            return _repository.AllAsReadOnly<Play>().AnyAsync(p => p.Id == playId);
        }

        public Task<PlayQueryModel> GetAllAsync(string? locationFilter = null, DateTime sortByDate = default, int page = 1, int playsPerPage = 10)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<PlayServiceModel>> GetAllPLaysByActorAsync(int actorId)
        {
            return await _repository.AllAsReadOnly<Play>()
                .Where(p => p.ActorsPlays.Any(ap => ap.ActorId == actorId))
                .Select(p => new PlayServiceModel
                {
					Id = p.Id,
					Title = p.Title,
					Description = p.Description,
					Genre = p.Genre,
					ImagesURL = p.PlayImagesURLs.FirstOrDefault() ?? string.Empty
				}).ToListAsync();
        }

        public async Task<PlayViewModel> GetByIdAsync(int playId)
        {
            return await _repository.AllAsReadOnly<Play>().Where(p => p.Id == playId)
				.Select(p => new PlayViewModel
                {
					Id = p.Id,
					Title = p.Title,
					Genre = p.Genre,
					Description = p.Description,
					Location = p.Location,
					DateAndTime = p.DateAndTime,
					TicketURL = p.TicketURL,
					Town = p.Town,
					ImagesURLs = p.PlayImagesURLs,
					VideosURLs = p.PlayVideosURLs,
					ActorsPlays = p.ActorsPlays.Select(ap => new ActorServiceModel
                    {
						Id = ap.Actor.Id,
						FirstName = ap.Actor.FirstName,
						LastName = ap.Actor.LastName,
						Description = ap.Actor.Description,
						ActorImageUrl = ap.Actor.ActorImageURLs.FirstOrDefault() ?? string.Empty
					}).ToList()
				}).FirstAsync();
        }

        private async void AddActorsToPlay(int playId, IEnumerable<int> actorsIds)
        {
			foreach (var actorId in actorsIds)
            {
				await _repository.AddAsync(new ActorPlay
                {
					ActorId = actorId,
					PlayId = playId
				});
			}
            
		}
    }
}
