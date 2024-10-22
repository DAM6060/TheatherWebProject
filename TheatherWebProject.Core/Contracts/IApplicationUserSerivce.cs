using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Contracts
{
	public interface IApplicationUserSerivce
	{
		Task CreateAsync(string userId, string displayName);

		Task<bool> ExistsIdentityUserByIdAsync(string idenitityUserId);

		Task<bool> ExistsApplicationUserByIdAsync(int applicationUserId);

	}
}
