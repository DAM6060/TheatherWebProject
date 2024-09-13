using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Infrastructure.Data.Seed.Configurations
{
	public class ActorPlayConfiguration : IEntityTypeConfiguration<ActorPlay>
	{
		public void Configure(EntityTypeBuilder<ActorPlay> builder)
		{
			var data = new SeedData();

			builder.HasData(data.ActorPlay1);
		}
	}
}
