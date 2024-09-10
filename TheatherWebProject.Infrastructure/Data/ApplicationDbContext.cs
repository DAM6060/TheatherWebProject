using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			// FavouritePlays many-to-many relationship
			builder.Entity<ApplicationUser>()
				.HasMany(u => u.FavouritePlays)
				.WithMany(p => p.ApplicationUsersFavouritePlays)
				.UsingEntity(j => j.ToTable("ApplicationUserFavouritePlays"));

			// LikedPlays many-to-many relationship
			builder.Entity<ApplicationUser>()
				.HasMany(u => u.LikedPlays)
				.WithMany(p => p.ApplicationUsersLikedPlays)
				.UsingEntity(j => j.ToTable("ApplicationUserLikedPlays"));

			// GoingToPlays many-to-many relationship
			builder.Entity<ApplicationUser>()
				.HasMany(u => u.GoingToPlays)
				.WithMany(p => p.ApplicationUsersGoingToPlays)
				.UsingEntity(j => j.ToTable("ApplicationUserGoingToPlays"));

			// WatchedPlays many-to-many relationship
			builder.Entity<ApplicationUser>()
				.HasMany(u => u.WatchedPlays)
				.WithMany(p => p.ApplicationUsersWatchedPlays)
				.UsingEntity(j => j.ToTable("ApplicationUserWatchedPlays"));

			base.OnModelCreating(builder);

		}

		public DbSet<Play> Plays { get; set; } = null!;

		public DbSet<Actor> Actors { get; set; } = null!;

		public DbSet<Comment> Comments { get; set; } = null!;

		public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;
	}
}
