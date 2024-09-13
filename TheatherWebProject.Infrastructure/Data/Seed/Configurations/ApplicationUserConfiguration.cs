using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Infrastructure.Data.Seed.Configurations
{
	public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
	{
		public void Configure(EntityTypeBuilder<ApplicationUser> builder)
		{
			var data = new SeedData();

			builder.HasData(data.User1);
		}
	}
}
