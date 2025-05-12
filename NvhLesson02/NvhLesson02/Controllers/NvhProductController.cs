using Microsoft.AspNetCore.Mvc;
using NvhLesson02.Models;

namespace NvhLesson02.Controllers
{
    public class NvhProductController : Controller
    {
        public IActionResult Index()
        {
            ViewData["nvhMessageVD"] = "DU lieu luu trong data";
            ViewBag.nvhMessage.VB = "Du lieu luu trong ViewBag";
            TempData["nvhMessageTD"] = "Du lieu luu trong TemData";
            return View();
        }
        public IActionResult NvhGetAllProducts()
        {
            List<NvhProduct> NvhProducts = new List<NvhProduct>
            {
                new NvhProduct() {NvhProductId = 1,NvhProductName = "Trek 820 - 2016",NvhYearReLease = 2016,NvhPrice = 379.999 },
                new NvhProduct() {NvhProductId = 2, NvhProductName = "Ritchay Timberwolf Frameset – 2016", NvhYearReLease = 2016, NvhPrice = 749.99 },
                new NvhProduct { NvhProductId = 3, NvhProductName = "Surly Wednesday Frameset – 2016", NvhYearReLease = 2016, NvhPrice = 999.99 },
                new NvhProduct { NvhProductId = 4, NvhProductName = "Trek Fuel EX 8 29 – 2016", NvhYearReLease = 2016, NvhPrice = 2899.99 },
                new NvhProduct { NvhProductId = 5, NvhProductName = "Heller Shagamaw Frame – 2016", NvhYearReLease = 2016, NvhPrice = 1320.99 },
                new NvhProduct { NvhProductId = 6, NvhProductName = "Surly Ice Cream Truck Frameset – 2016", NvhYearReLease = 2016, NvhPrice = 469.99 },
                new NvhProduct { NvhProductId = 7, NvhProductName = "Trek Slash 8 27.5 – 2016", NvhYearReLease = 2016, NvhPrice = 3999.99 },
                new NvhProduct { NvhProductId = 8, NvhProductName = "Trek Remedy 29 Carbon Frameset – 2016", NvhYearReLease = 2016, NvhPrice = 1799.99 },
                new NvhProduct { NvhProductId = 9, NvhProductName = "Trek Conduit+ – 2016", NvhYearReLease = 2016, NvhPrice = 2999.99 },
                new NvhProduct { NvhProductId = 10, NvhProductName = "Surly Straggler – 2016", NvhYearReLease = 2016, NvhPrice = 1549.99 },
                new NvhProduct { NvhProductId = 11, NvhProductName = "Surly Straggler 650b – 2016", NvhYearReLease = 2016, NvhPrice = 1680.99 },
                new NvhProduct { NvhProductId = 12, NvhProductName = "Electra Townie Original 21D – 2016", NvhYearReLease = 2016, NvhPrice = 549.99 },
                new NvhProduct { NvhProductId = 13, NvhProductName = "Electra Cruiser 1 (24-Inch) – 2016", NvhYearReLease = 2016, NvhPrice = 269.99 },
                new NvhProduct { NvhProductId = 14, NvhProductName = "Electra Girl's Hawaii 1 (16-inch) – 2016", NvhYearReLease = 2016, NvhPrice = 269.99 },

            };
            ViewBag.NvhProducts = NvhProducts;
            return View("NvhProducts"); 
        }
    }
}
