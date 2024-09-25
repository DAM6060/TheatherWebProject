using TheatherWebProject.Core.Models.Plays;

namespace TheatherWebProject.Core.Contracts
{
    public interface IPlayService
	{
		Task<int> CreateAsync(PlayFormModel model);

		Task DeleteAsync(int playId);

		Task EditAsync(int playId, PlayFormModel model);

		Task<PlayViewModel> GetByIdAsync(int playId);

		Task<bool> ExistsById(int playId);

		Task<PlayQueryModel> GetAllAsync(
			string? locationFilter = null,
			DateTime sortByDate = default,
			int page = 1,
			int playsPerPage = 10);

		Task<IEnumerable<PlayServiceModel>> GetAllPLaysByActorAsync(int actorId);

	}
}
