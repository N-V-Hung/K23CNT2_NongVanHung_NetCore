using Microsoft.AspNetCore.Mvc;

namespace nvhbaitap.Controllers
{
    public class NvhHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
