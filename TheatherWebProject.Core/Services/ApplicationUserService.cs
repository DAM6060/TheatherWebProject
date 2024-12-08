using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using TheatherWebProject.Core.Contracts;
using TheatherWebProject.Infrastructure.Data.Common;
using TheatherWebProject.Infrastructure.Data.Models;

namespace TheatherWebProject.Core.Services
{
	public class ApplicationUserService : IApplicationUserSerivce
	{
		private readonly IRepository _repository;

		public ApplicationUserService(IRepository repository)
		{
			_repository = repository;
		}
		public async Task CreateAsync(string userId, string displayName)
		{
			await _repository.AddAsync(new ApplicationUser
			{
				DisplayName = displayName,
				IdentityUserId = userId,
			});

			await _repository.SaveChangesAsync();
		}

		public Task<bool> ExistsApplicationUserByIdAsync(int applicationUserId)
		{
			return _repository.AllAsReadOnly<ApplicationUser>()
				.AnyAsync(p => p.Id == applicationUserId);
		}

		public async Task<bool> ExistsIdentityUserByIdAsync(string idenitityUserId)
		{
			return (await _repository.AllAsReadOnly<ApplicationUser>()
				.AnyAsync(p => p.IdentityUserId == idenitityUserId));
		}
	}
}
