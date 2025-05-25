using Microsoft.AspNetCore.Mvc;
using NvhLesson05.Models;
using System.Diagnostics;

namespace NvhLesson05.Controllers
{
	public class NvhHomeController : Controller
	{
		private readonly ILogger<NvhHomeController> _logger;

		public NvhHomeController(ILogger<NvhHomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
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
