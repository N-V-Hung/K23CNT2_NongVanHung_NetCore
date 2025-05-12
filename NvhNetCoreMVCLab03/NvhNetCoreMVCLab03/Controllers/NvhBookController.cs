using Microsoft.AspNetCore.Mvc;

namespace NvhNetCoreMVCLab03.Controllers
{
    public class NvhBookController : Controller
    {
        protected NvhBook nvhbook = new NvhBook();
        public IActionResult Index()
        {
            ViewBag.nvhAuthors = nvhbook.NvhAuthors;
            ViewBag.nvhGenres = nvhbook.NvhGenres;
            var nvhbooks = nvhbook.NVhGetBookList();
            return View(nvhbooks);
        }
    }
}
