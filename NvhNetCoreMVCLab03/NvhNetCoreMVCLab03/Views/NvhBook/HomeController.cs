using Microsoft.AspNetCore.Mvc;

namespace NvhNetCoreMVCLab03.Views.NvhBook
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
