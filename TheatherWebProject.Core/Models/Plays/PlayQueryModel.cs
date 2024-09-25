using TheatherWebProject.Core.Models.Paging;

namespace TheatherWebProject.Core.Models.Plays
{
    public class PlayQueryModel : PagingModel
	{
		public IEnumerable<PlayServiceModel> Plays { get; set; } = new List<PlayServiceModel>();

		public string LocationFilter { get; set; } = string.Empty;

		public IEnumerable<string> LocationsForFilter { get; set; } = new List<string>();

		public DateTime DateTimeSorting { get; set; } = DateTime.Now;
	}
}
