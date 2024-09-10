using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Infrastructure.Data.Models
{
	public class Comment
	{
		public int Id { get; set; }

		public required string Content { get; set; } = string.Empty;

		public required DateTime CreatedOn { get; set; }

		public required int PlayId { get; set; }
		public Play Play { get; set; } = null!;

		public required int UserId { get; set; }
		public User User { get; set; } = null!;

		
	}
}
