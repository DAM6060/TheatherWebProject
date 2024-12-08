using System.ComponentModel.DataAnnotations;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class Actor
	{
		[Key]
		public int Id { get; set; }

		public required string FirstName { get; set; } =string.Empty;

		public required string LastName { get; set; } = string.Empty;

		public required string Description { get; set; } = string.Empty;

		public required List<string> ActorImageURLs { get; set; } = new List<string>();

		public List<ActorPlay> ActorsPlays { get; set; } = new List<ActorPlay>();

	}
}
