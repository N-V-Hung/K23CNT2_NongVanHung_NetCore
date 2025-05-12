using Microsoft.AspNetCore.Mvc;
using NvhLesson02.Models;

namespace NvhLesson02.Controllers
{
    public class NvhAccountController : Controller
    {
        public IActionResult Index()
        {
            List<NvhAccunt> nvhAccunts = new List<NvhAccunt>
            {
                new NvhAccunt()
                {
                    NvhId = 1,
                    NvhName = "Hoang Anh",
                    NvhEmail ="anh@gmail.com",
                    NvhPhone ="09876654333",
                    NvhAddress="Ha Noi",
                    NvhAvatar= Url.Content("~/Avatar/02.jfif"),
                    NvhGender =1,
                    NvhBio="My name is small",
                    NvhBirthDay= new DateTime(1998,7,15)
                },
                new NvhAccunt()
                {
                    NvhId = 2,
                    NvhName = "Truong Giang",
                    NvhEmail ="giang@gmail.com",
                    NvhPhone ="09876654333",
                    NvhAddress="Ha Noi",
                    NvhAvatar= Url.Content("~/Avatar/03.jfif"),
                    NvhGender =1,
                    NvhBio="My name is small",
                    NvhBirthDay= new DateTime(1998,7,15)
                },
                new NvhAccunt()
                {
                    NvhId = 1,
                    NvhName = "Hoang Thuy",
                    NvhEmail ="thuy@gmail.com",
                    NvhPhone ="09876654333",
                    NvhAddress="Ha Noi",
                    NvhAvatar= Url.Content("~/Avatar/04.jfif"),
                    NvhGender =1,
                    NvhBio="My name is small",
                    NvhBirthDay= new DateTime(1998,7,15)
                },
            };
            ViewBag.NvhAccounts = nvhAccunts;
            return View();
        }
    }
}
