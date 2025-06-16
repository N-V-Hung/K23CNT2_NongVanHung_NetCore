using Microsoft.AspNetCore.Mvc;
using NvhLesson09EF.Models;
using System.Diagnostics;

namespace NvhLesson09EF.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
