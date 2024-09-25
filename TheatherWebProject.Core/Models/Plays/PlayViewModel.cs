using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.ApplicationUser;
using TheatherWebProject.Core.Models.Comments;
using TheatherWebProject.Core.Services;

namespace TheatherWebProject.Core.Models.Plays
{
	public class PlayViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;

		public string Genre { get; set; } = string.Empty;

		public List<string> ImagesURLs { get; set; } = new List<string>();

		public List<string> VideosURLs { get; set; } = new List<string>();

		public string Location { get; set; } = string.Empty;

		public string Town { get; set; } = string.Empty;

		public DateTime DateAndTime { get; set; }

		public string TicketURL { get; set; } = string.Empty;

		public ICollection<CommentViewModel> Comments { get; set; } = new List<CommentViewModel>();
		
		public ICollection<ActorServiceModel> ActorsPlays { get; set; } = new List<ActorServiceModel>();

		public ICollection<ApplicationUserServiceModel> ApplicationUsersFavouritePlays { get; set; } = new List<ApplicationUserServiceModel>();

		public ICollection<ApplicationUserServiceModel> ApplicationUsersLikedPlays { get; set; } = new List<ApplicationUserServiceModel>();

		public ICollection<ApplicationUserServiceModel> ApplicationUsersGoingToPlays { get; set; } = new List<ApplicationUserServiceModel>();

		public ICollection<ApplicationUserServiceModel> ApplicationUsersWatchedPlays { get; set; } = new List<ApplicationUserServiceModel>();

		public string DateAndTimeFormatted => DateAndTime.ToString("dd/MM/yyyy HH:mm");
	}
}
