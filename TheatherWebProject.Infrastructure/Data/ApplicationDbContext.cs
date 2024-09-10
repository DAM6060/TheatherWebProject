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
			builder.Entity<User>()
				.HasMany(u => u.FavouritePlays)
				.WithMany(p => p.UsersFavouritePlays)
				.UsingEntity(j => j.ToTable("UserFavouritePlays"));

			// LikedPlays many-to-many relationship
			builder.Entity<User>()
				.HasMany(u => u.LikedPlays)
				.WithMany(p => p.UsersLikedPlays)
				.UsingEntity(j => j.ToTable("UserLikedPlays"));

			// GoingToPlays many-to-many relationship
			builder.Entity<User>()
				.HasMany(u => u.GoingToPlays)
				.WithMany(p => p.UsersGoingToPlays)
				.UsingEntity(j => j.ToTable("UserGoingToPlays"));

			// WatchedPlays many-to-many relationship
			builder.Entity<User>()
				.HasMany(u => u.WatchedPlays)
				.WithMany(p => p.UsersWatchedPlays)
				.UsingEntity(j => j.ToTable("UserWatchedPlays"));

			base.OnModelCreating(builder);

		}

		public DbSet<Play> Plays { get; set; } = null!;

		public DbSet<Actor> Actors { get; set; } = null!;

		public DbSet<Comment> Comments { get; set; } = null!;

		public DbSet<User> Users { get; set; } = null!;
	}
}
