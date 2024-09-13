using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TheatherWebProject.Infrastructure.Data.Models;
using TheatherWebProject.Infrastructure.Data.Seed.Configurations;

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
			builder.Entity<ActorPlay>()
				.HasKey(ap => new { ap.ActorId, ap.PlayId });

			builder.Entity<ActorPlay>()
			.HasOne(ap => ap.Actor)
			.WithMany(a => a.ActorsPlays)
			.HasForeignKey(ap => ap.ActorId);

			builder.Entity<ActorPlay>()
				.HasOne(ap => ap.Play)
				.WithMany(p => p.ActorsPlays)
				.HasForeignKey(ap => ap.PlayId);

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

			builder.ApplyConfiguration(new IdentityUserConfiguration());
			builder.ApplyConfiguration(new ApplicationUserConfiguration());
			builder.ApplyConfiguration(new ActorConfiguration());
			builder.ApplyConfiguration(new PlayConfiguration());
			builder.ApplyConfiguration(new CommentConfiguration());
			builder.ApplyConfiguration(new ActorPlayConfiguration());

			base.OnModelCreating(builder);

		}

		public DbSet<Play> Plays { get; set; } = null!;

		public DbSet<Actor> Actors { get; set; } = null!;

		public DbSet<Comment> Comments { get; set; } = null!;

		public DbSet<ApplicationUser> ApplicationUsers { get; set; } = null!;

		public DbSet<ActorPlay> ActorsPlays { get; set; } = null!;

		
	}
}
