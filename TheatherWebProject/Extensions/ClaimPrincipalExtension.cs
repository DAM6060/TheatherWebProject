using static TheatherWebProject.Areas.Admin.AdminConstants;

namespace System.Security.Claims
{
	public static class ClaimPrincipalExtension
	{
		public static bool IsAdmin(this ClaimsPrincipal user)
		   => user.IsInRole(AdministratorRoleName);
	}
}
