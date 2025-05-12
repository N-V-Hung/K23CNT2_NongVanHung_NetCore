using Microsoft.AspNetCore.Mvc.Rendering;

namespace NvhNetCoreMVCLab03.Models
{
    public class NvhBook
    {
        public int NvhId { get; set; }
        public string NvhTitle { get; set; }
        public int NvhAuthorId { get; set; }
        public int NvhGenreId { get; set; }
        public string NvhImage { get; set; }
        public float NvhPrice { get; set; }
        public int NvhTotalPage { get; set; }
        public string NvhSumary { get; set; }
    }
    public List<NvhBook> NvhGetBookList()
    {
        List<NvhBook> nvhbooks = new List<NvhBook>()
        {
            new NvhBook()
            {
                NvhId = 1,
                NvhTitle ="Chi pheo",
                NvhAuthorId = 1,
                NvhGenreId = 1,
                NvhImage="/images/products/01.jpg"
            },
            new NvhBook()
            {
                NvhId = 2,
                NvhTitle ="tat den",
                NvhAuthorId = 1,
                NvhGenreId = 1,
                NvhImage="/images/products/02.jpg"
            },
            new NvhBook()
            {
                NvhId = 3,
                NvhTitle ="vo nhat",
                NvhAuthorId = 1,
                NvhGenreId = 1,
                NvhImage="/images/products/03.jpg"
            },
            new NvhBook()
            {
                NvhId = 4,
                NvhTitle ="lao hac",
                NvhAuthorId = 1,
                NvhGenreId = 1,
                NvhImage="/images/products/04.jpg"
            },
        };
    }
    public NvhBook NvhGetBookById(int id)
    {
        NvhBook nvhbook = this.NvhGetBookList().FirstOrDefault(b => b.NvhId == id);
        return nvhbook;
    }
    public List<SelectListItem> NvhAuthors { get; } = new List<SelectListItem>
    {
        new SelectListItem{Value="1" , Text="Nam Cao"},
        new SelectListItem{Value="2" , Text= "Ngo Tat To" },
        new SelectListItem{Value="3" , Text= "Ngo Tat To" },
        new SelectListItem{Value="2" , Text= "Nguyen du" },
    };



    public List<SelectListItem> NvhGenres { get; } = new List<SelectListItem>
        {
         new SelectListItem{Value="1" , Text="Truyen tranh"},
         new SelectListItem{Value="2" , Text="van hoc duong dai" },
         new SelectListItem{Value="3" , Text="tho ca " },
         new SelectListItem{Value="4" , Text="truyen cuoi" };
    };

}
