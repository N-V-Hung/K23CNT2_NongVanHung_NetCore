using Microsoft.AspNetCore.Mvc;

namespace nvhMyAppMVC.Controllers
{
    public class NvhDemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
