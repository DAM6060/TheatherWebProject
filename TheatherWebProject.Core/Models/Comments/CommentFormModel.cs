using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Models.Comments
{
	public class CommentFormModel
	{
		public string Content { get; set; } = string.Empty;

		public DateTime CreatedOn { get; set; }

		public int PlayId { get; set; }

		public int ApplicationUserId { get; set; }
	}
}
