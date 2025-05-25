using Microsoft.AspNetCore.Mvc;

namespace NvhLesson05.Controllers
{
	public class nvhMemberController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult NvhGetMember()
		{
			var nvhMember = new NvhMember();
			nvhMember.NvhMemberId = Guid.NewGuid().ToString();
			nvhMember.NvhUserName = "VanHung";
			nvhMember.NvhFullName = "Nong Van Hung";
			nvhMember.NvhPassword = "123456a@";
			nvhMember.NvhEmail = "nongvanhungcb2k5@gmail.com";

			ViewBag.nvhMember = nvhMember;
			return View();
		}
	}
}
