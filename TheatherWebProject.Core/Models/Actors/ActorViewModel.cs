using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Models.Plays;

namespace TheatherWebProject.Core.Models.Actors
{
	public class ActorViewModel
	{
		public int Id { get; set; }

		public string FirstName { get; set; } = string.Empty;

		public string LastName { get; set; } = string.Empty;

		public string Description { get; set; } = string.Empty;

		public List<string> ActorImageUrls { get; set; } = new List<string>();

		public string FullName => $"{FirstName} {LastName}";

		public IEnumerable<PlayServiceModel> actingIn { get; set; } = new List<PlayServiceModel>();


	}
}
