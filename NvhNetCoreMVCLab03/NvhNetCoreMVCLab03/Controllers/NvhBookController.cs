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
        public IActionResult NvhCreate()
        {
            ViewBag.nvhAuthors = nvhbook.NvhAuthors;
            ViewBag.nvhGenres = nvhbook.NvhGenres;
            NvhBook model = new NvhBook();
            return View(model);
        }
    }
}
