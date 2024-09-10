using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class ApplicationUser
	{
		[Key]
		public int Id { get; set; }

		public required string IdentityUserId { get; set; } =string.Empty;

		[ForeignKey(nameof(IdentityUserId))]
		public required IdentityUser IdentityUser { get; set; } = null!;

		public List<Play> FavouritePlays { get; set; } = new List<Play>();

		public List<Play> LikedPlays { get; set; } = new List<Play>();

		public List<Play> GoingToPlays { get; set; } = new List<Play>();

		public List<Play> WatchedPlays { get; set; } = new List<Play>();
	}
}
