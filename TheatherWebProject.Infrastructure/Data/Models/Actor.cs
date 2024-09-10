using System.ComponentModel.DataAnnotations;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		public required string NameFirst { get; set; } =string.Empty;

		public required string NameLast { get; set; } = string.Empty;

		public required string Description { get; set; } = string.Empty;

		public required string ActorImageURL { get; set; } = string.Empty;

		public List<Play> Plays { get; set; } = new List<Play>();





		
	}
}
