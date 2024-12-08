using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Models.Comments
{
	public class CommentViewModel
	{
		public int Id { get; set; }
		public string Content { get; set; } = string.Empty;

		public DateTime CreatedOn { get; set; }

		public int PlayId { get; set; }

		public string PlayName { get; set; } = string.Empty;

		public int ApplicationUserId { get; set; }

		public string ApplicationUserDisplayName { get; set; } = string.Empty;
	}
}
