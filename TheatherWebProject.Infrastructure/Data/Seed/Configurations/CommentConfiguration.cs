using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Infrastructure.Data.Seed.Configurations
{
	public class CommentConfiguration : IEntityTypeConfiguration<Comment>
	{
		public void Configure(EntityTypeBuilder<Comment> builder)
		{
			var data = new SeedData();

			builder.HasData(data.Comment);
		}
	}
	
}
