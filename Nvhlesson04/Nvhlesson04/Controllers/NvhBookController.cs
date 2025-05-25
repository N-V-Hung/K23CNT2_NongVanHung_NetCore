using Microsoft.AspNetCore.Mvc;
using Nvhlesson04.Models;

namespace Nvhlesson04.Controllers
{
    public class NvhBookController : Controller
    {
        protected Books book =new Books();
        public IActionResult NvhIndex()
        {
            ViewBag.authors = book.Authors;
            ViewBag.genres = book.Genres;
            var books = book.GetBookList();
            return View(books);
        }
    }
}
