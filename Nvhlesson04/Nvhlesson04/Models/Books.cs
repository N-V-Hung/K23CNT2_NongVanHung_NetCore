using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Cryptography.Xml;

namespace Nvhlesson04.Models
{
    public class Books : Controller
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float price { get; set; }
        public int TotaPage { get; set; }
        public string Summary {  get; set; }

        public List<Books> GetBookList()
        {
            List<Books> books = new List<Books>()
            {
                new Books()
                {
                    Title ="ApspNe",
                    AuthorId = 1,
                    GenreId = 1,
                    Image="/image/book01.jpg",
                    price=12000,
                    TotaPage = 100,
                    Summary =""
                },
                 new Books()
                {
                    Title ="ApspNe",
                    AuthorId = 2,
                    GenreId = 2,
                    Image="/image/book01.jpg",
                    price=12000,
                    TotaPage = 100,
                    Summary =""
                    },
                  new Books()
                    {
                    Title ="ApspNe",
                    AuthorId = 3,
                    GenreId = 3,
                    Image="/image/book03.jpg",
                    price=12000,
                    TotaPage = 100,
                    Summary =""
                    },
            };
            return books;
        }
        public Books  GetBookById(int id)
        {
            Books books = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return books;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1" ,Text="Nam Cao"},
            new SelectListItem{Value="2" ,Text="Ngo tat to" },
            new SelectListItem{Value="3" ,Text="Adamkhoom" },
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem{Value="1" ,Text="Truyen tranh" },
            new SelectListItem{Value="2" ,Text="van hoc duong dai" },
            new SelectListItem{Value="3" ,Text="Phat hoc pho thong" },
        };

    }
}
  
