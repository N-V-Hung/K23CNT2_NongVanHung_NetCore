using Microsoft.AspNetCore.Mvc;
using NvhWebBanHang.Models;

namespace NvhWebBanHang.Controllers
{
    public class NvhProductController1 : Controller
    {
        public IActionResult Index()
        {
            var NvhProducts = new List<NvhProduct>
            {
                new NvhProduct { NvhID = 1, NvhName = "Product 1", NvhPrice = 600000, NvhCreatedAt = new DateTime(2020, 12, 25), NvhImage = "bag1.png" },
                new NvhProduct { NvhID = 2, NvhName = "Product 2", NvhPrice = 700000, NvhCreatedAt = new DateTime(2020, 12, 25), NvhImage = "bag2.png" },
                new NvhProduct { NvhID = 3, NvhName = "Product 3", NvhPrice = 600000, NvhCreatedAt = new DateTime(2020, 12, 25), NvhImage = "bag3.png" },
                new NvhProduct { NvhID = 4, NvhName = "Product 4", NvhPrice = 600000, NvhCreatedAt = new DateTime(2020, 12, 25), NvhImage = "bag4.png" },

            };
            return View(NvhProducts);
        }
    }
}
