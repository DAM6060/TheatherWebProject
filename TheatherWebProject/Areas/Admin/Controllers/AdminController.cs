using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static TheatherWebProject.Areas.Admin.AdminConstants;


namespace TheatherWebProject.Areas.Admin.Controllers
{
	[Area(AreaName)]
	[Authorize(Roles = AdministratorRoleName)]
	public class AdminController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
