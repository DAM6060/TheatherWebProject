using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Infrastructure.Data.Seed.Configurations
{
	public class PlayCOnfiguration : IEntityTypeConfiguration<Play>
	{
		public void Configure(EntityTypeBuilder<Play> builder)
		{
			var data = new SeedData();

			builder.HasData(data.Play);
		}
	}
}
