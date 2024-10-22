using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.Comments;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Core.Contracts
{
	public interface ICommentService
	{
		Task<IEnumerable<CommentViewModel>> GetAllCommentsForPlayByIDAsync(int playId);

		Task DeleteAsync(int commentId);

		Task EditAsync(int commentId, CommentFormModel model);

		Task AddCommentAsync(CommentFormModel model, int appUserId, int playId);

		Task<bool> ExistsByIdAsync(int commentId);
	}
}
