﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class Play
	{
		[Key]
		public int Id { get; set; }

		public required string Title { get; set; } = string.Empty;

		public required string Description { get; set; } = string.Empty;

		public required List<string> PlayImagesURLs { get; set; } = new List<string>();

		public required List<string> PlayVideosURLs { get; set; } = new List<string>();

		public required string Location { get; set; } = string.Empty;

		public required DateTime DateAndTime { get; set; }

		public required string TicketURL { get; set; } = string.Empty;

		public required ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();

		public required ICollection<Actor> Actors { get; set; } = new HashSet<Actor>();

		public required ICollection<ApplicationUser> ApplicationUsersFavouritePlays { get; set; } = new HashSet<ApplicationUser>();
		public required ICollection<ApplicationUser> ApplicationUsersLikedPlays { get; set; } = new HashSet<ApplicationUser>();
		public required ICollection<ApplicationUser> ApplicationUsersGoingToPlays { get; set; } = new HashSet<ApplicationUser>();
		public required ICollection<ApplicationUser> ApplicationUsersWatchedPlays { get; set; } = new HashSet<ApplicationUser>();



	}
}
