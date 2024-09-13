using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Infrastructure.Data.Seed.Configurations
{
	public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
	{

		public void Configure(EntityTypeBuilder<IdentityUser> builder)
		{
			var data = new SeedData();

			builder.HasData(data.AdminUser, data.IdentityUser);
		}
	}
}
