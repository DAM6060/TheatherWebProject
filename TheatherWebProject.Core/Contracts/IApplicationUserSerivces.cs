using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheatherWebProject.Core.Contracts
{
	public interface IApplicationUserSerivces
	{
		Task<int> CreateAsync(string userId, string displayName);

		Task<bool> ExistsByIdAsync(string idenitityUserId);


	}
}
