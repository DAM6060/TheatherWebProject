using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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

		[ForeignKey(nameof(PlayId))]
		public Play Play { get; set; } = null!;

		public required int ApplicationUserId { get; set; }

		[ForeignKey(nameof(ApplicationUserId))]
		public ApplicationUser User { get; set; } = null!;

		
	}
}
