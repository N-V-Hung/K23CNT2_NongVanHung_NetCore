using Microsoft.AspNetCore.Mvc;
using Nvhlesson04.Models;
using System.Diagnostics;

namespace Nvhlesson04.Controllers
{
	public class NvhHomeController : Controller
	{
		private readonly ILogger<NvhHomeController> _logger;

		public NvhHomeController(ILogger<NvhHomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult NvhIndex()
		{
			return View();
		}
		public IActionResult NvhAbout()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
