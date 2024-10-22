using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Core.Models.Actors;
using TheatherWebProject.Core.Models.Comments;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Core.Services
{
	public class CommentService : ICommentService
	{
		private readonly IRepository _repository;
		private readonly IApplicationUserSerivce _applicationUserSerivce;
		private readonly IPlayService _playService;

		public CommentService(IRepository repository,
			IApplicationUserSerivce applicationUserSerivce,
			IPlayService playService)
		{
			_repository = repository;
			_applicationUserSerivce = applicationUserSerivce;
			_playService = playService;
		}
		public async Task AddCommentAsync(CommentFormModel model, int appUserId, int playId)
		{
			if (await _applicationUserSerivce.ExistsApplicationUserByIdAsync(appUserId) &&
				await _playService.ExistsByIdAsync(playId))
			{
				var comment = new Comment
				{
					Content = model.Content,
					PlayId = playId,
					ApplicationUserId = appUserId,
					CreatedOn = model.CreatedOn,
				};

				await _repository.AddAsync(comment);
				await _repository.SaveChangesAsync();
			}
			else
			{
				throw new InvalidOperationException("Invalid user or play id");
			}

		}

		public async Task DeleteAsync(int commentId)
		{
			var comment = await _repository.All<Comment>()
				.FirstOrDefaultAsync(c => c.Id == commentId);

			if (comment != null)
			{
				await _repository.DeleteAsync<Comment>(commentId);
				await _repository.SaveChangesAsync();
			}
		}

		public async Task EditAsync(int commentId, CommentFormModel model)
		{
			if (await ExistsByIdAsync(commentId))
			{
				var comment = await _repository.GetByIdAsync<Comment>(commentId);

				comment.Content = model.Content;
				comment.CreatedOn = model.CreatedOn;

				_repository.SaveChangesAsync();
			}
			else
			{
				throw new InvalidOperationException("Invalid comment id");
			}
		}

		public async Task<bool> ExistsByIdAsync(int commentId)
		{
			return await _repository.AllAsReadOnly<Comment>()
				.AnyAsync(c => c.Id == commentId);
		}

		public async Task<IEnumerable<CommentViewModel>> GetAllCommentsForPlayByIDAsync(int playId)
		{
			var comments = await _repository.AllAsReadOnly<Comment>()
				.Where(c => c.PlayId == playId)
				.Select(c => new CommentViewModel
				{
					
				})
				.ToListAsync();

			return comments;
		}

		
	}
}
