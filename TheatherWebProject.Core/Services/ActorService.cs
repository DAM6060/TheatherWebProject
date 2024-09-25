using Microsoft.EntityFrameworkCore;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.Plays;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Core.Services
{
	public class ActorService : IActorService
	{
		private readonly IRepository _repository;

		public ActorService(IRepository repository)
		{
			_repository = repository;
		}

		public async Task<int> CreateAsync(ActorFormModel model)
		{
			var actor = new Actor
			{
				FirstName = model.FirstName,
				LastName = model.LastName,
				Description = model.Description,
				ActorImageURLs = model.ActorImageUrls
			};

			await _repository.AddAsync(actor);
			await _repository.SaveChangesAsync();

			return actor.Id;

		}

		public async Task DeleteAsync(int actorId)
		{
			await _repository.All<ActorPlay>()
				.Where(ap => ap.ActorId == actorId)
				.ForEachAsync(ap => _repository
				.DeleteAsync<ActorPlay>(actorId));

			await _repository.DeleteAsync<Actor>(actorId);
			await _repository.SaveChangesAsync();
		}

		public async Task EditAsync(int actorId, ActorFormModel model)
		{
			var actor = _repository.All<Actor>()
				.Include(a => a.ActorsPlays)
				.FirstOrDefault(a => a.Id == actorId);

			if (actor != null)
			{
				actor.FirstName = model.FirstName;
				actor.LastName = model.LastName;
				actor.Description = model.Description;
				actor.ActorImageURLs = model.ActorImageUrls; 

				await _repository.SaveChangesAsync();
			}
			else
			{
				throw new InvalidOperationException("Actor not found");
			}

		}

		public async Task<bool> ExistsByIdAsync(int actorId)
		{
			return await _repository.AllAsReadOnly<Actor>().AnyAsync(a => a.Id == actorId);
		}

		public async Task<IEnumerable<ActorServiceModel>> GetAllAsync()
		{
			return await _repository.AllAsReadOnly<Actor>().Select(a => new ActorServiceModel
			{
				Id = a.Id,
				FirstName = a.FirstName,
				LastName = a.LastName,
				Description = a.Description,
				ActorImageUrl = a.ActorImageURLs.FirstOrDefault() ?? string.Empty
			}).ToListAsync();
			

		}

		public async Task<ActorViewModel> GetDetailsByIdAsync(int actorId)
		{
			return await _repository.AllAsReadOnly<Actor>()
				.Where(a => a.Id == actorId)
				.Select(a => new ActorViewModel
				{
					Id = a.Id,
					FirstName = a.FirstName,
					LastName = a.LastName,
					Description = a.Description,
					ActorImageUrls = a.ActorImageURLs,
					actingIn = a.ActorsPlays.Select(ap => new PlayServiceModel
					{
						Id = ap.Play.Id,
						Title = ap.Play.Title,
					})
				}).FirstAsync();			 
		}
	}
}
