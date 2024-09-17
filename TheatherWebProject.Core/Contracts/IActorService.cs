using TheatherWebProject.Core.Models.Actors;

namespace TheatherWebProject.Core.Contracts
{
	public interface IActorService
	{
		Task<int> CreateAsync(ActorFormModel model);

		Task<IEnumerable<ActorViewModel>> GetAllAsync();
		
		Task DeleteAsync(int actorId);

		Task EditAsync(int actorId, ActorFormModel model);
	}
}
