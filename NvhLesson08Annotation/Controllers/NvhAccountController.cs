using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NvhLesson08Annotation.Models;

namespace NvhLesson08Annotation.Controllers
{
    public class NvhAccountController : Controller
    {
        private static List<NvhAccount> nvhListAccount = new List<NvhAccount>()
        {
            new NvhAccount
                {
                    NvhId = 230022113,
                    NvhFullName = "Nong Van Hung",
                    NvhEmail = "nongvanhungcb2k5@gmail.com",
                    NvhPhone = "0833484935",
                    NvhAddress = "Lớp K23CNT2",
                    NvhAvatar = "vanhung.jpg",
                    NvhBirthDay = new DateTime(2005, 8, 14),
                    NvhGender = "Nam",
                    NvhPassword = "0978611889",
                    NvhFacebook = "https://facebook.com/"
                },
                new NvhAccount
                {
                    NvhId = 2,
                    NvhFullName = "Trần Thị B",
                    NvhEmail = "tranthib@example.com",
                    NvhPhone = "0987654321",
                    NvhAddress = "456 Đường B, Quận 3, TP.HCM",
                    NvhAvatar = "avatar2.jpg",
                    NvhBirthDay = new DateTime(1992, 8, 15),
                    NvhGender = "Nữ",
                    NvhPassword = "password2",
                    NvhFacebook = "https://facebook.com/tranthib"
                },
                new NvhAccount
                {
                    NvhId = 3,
                    NvhFullName = "Lê Văn C",
                    NvhEmail = "levanc@example.com",
                    NvhPhone = "0911222333",
                    NvhAddress = "789 Đường C, Quận 5, TP.HCM",
                    NvhAvatar = "avatar3.jpg",
                    NvhBirthDay = new DateTime(1988, 12, 1),
                    NvhGender = "Nam",
                    NvhPassword = "password3",
                    NvhFacebook = "https://facebook.com/levanc"
                },
                new NvhAccount
                {
                    NvhId = 4,
                    NvhFullName = "Phạm Thị D",
                    NvhEmail = "phamthid@example.com",
                    NvhPhone = "0909876543",
                    NvhAddress = "321 Đường D, Quận 7, TP.HCM",
                    NvhAvatar = "avatar4.jpg",
                    NvhBirthDay = new DateTime(1995, 3, 10),
                    NvhGender = "Nữ",
                    NvhPassword = "password4",
                    NvhFacebook = "https://facebook.com/phamthid"
                },
                new NvhAccount
                {
                    NvhId = 5,
                    NvhFullName = "Hoàng Văn E",
                    NvhEmail = "hoangvane@example.com",
                    NvhPhone = "0933444555",
                    NvhAddress = "654 Đường E, Quận 10, TP.HCM",
                    NvhAvatar = "avatar5.jpg",
                    NvhBirthDay = new DateTime(1991, 7, 22),
                    NvhGender = "Nam",
                    NvhPassword = "password5",
                    NvhFacebook = "https://facebook.com/hoangvane"
                }
        };
        // GET: NvhAccoutController
        public ActionResult NvhIndex()
        {
            return View(nvhListAccount);
        }

        // GET: NvhAccoutController/Details/5
        public ActionResult NvhDetails(int id)
        {
            var nvhModel = nvhListAccount.FirstOrDefault(e => e.NvhId == id);

            return View(nvhModel);
        }

        // GET: NvhAccoutController/Create
        public ActionResult NvhCreate()
        {
            var nvhModel = new NvhAccount();
            return View(nvhModel);
        }

        // POST: NvhAccoutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhCreate(NvhAccount nvhModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!nvhListAccount.Any(e => e.NvhId == nvhModel.NvhId))
                    {
                        nvhModel.NvhId = nvhListAccount.Max(e => e.NvhId) + 1;
                    }
                    // Giả sử bạn có DbContext tên _context đã được Inject trong Controller
                    //_context.NvhAccounts.Add(nvhModel);
                    //_context.SaveChanges();
                    nvhListAccount.Add(nvhModel);
                    return RedirectToAction(nameof(NvhIndex));
                }

                // Nếu dữ liệu không hợp lệ, trả về View để người dùng sửa
                return View(nvhModel);
            }
            catch (Exception ex)
            {
                // Bạn có thể log lỗi ở đây nếu cần
                ModelState.AddModelError("", "Có lỗi xảy ra khi thêm mới: " + ex.Message);
                return View(nvhModel);
            }
        }

        // GET: NvhAccoutController/Edit/5
        public ActionResult NvhEdit(int id)
        {
            var nvhModel = nvhListAccount.FirstOrDefault(e => e.NvhId == id);

            return View(nvhModel);
        }

        // POST: NvhAccoutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhEdit(NvhAccount nvhModel)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (!nvhListAccount.Any(e => e.NvhId == nvhModel.NvhId))
                    {
                        nvhModel.NvhId = nvhListAccount.Max(e => e.NvhId) + 1;
                    }

                    nvhListAccount.Add(nvhModel);
                    return RedirectToAction(nameof(NvhIndex));
                }

                return View(nvhModel);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", "Có lỗi xảy ra khi sua: " + ex.Message);
                return View(nvhModel);
            }
        }


        public ActionResult NvhDelete(int id)
        {
            var nvhModel = nvhListAccount.FirstOrDefault(e => e.NvhId == id);
            if (nvhModel == null)
            {
                return NotFound();
            }
            return View(nvhModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult NvhDelete(int id, NvhAccount nvhModel)
        {
            try
            {
                var itemToDelete = nvhListAccount.FirstOrDefault(e => e.NvhId == id);
                if (itemToDelete != null)
                {
                    nvhListAccount.Remove(itemToDelete);
                }
                return RedirectToAction(nameof(NvhIndex));
            }
            catch
            {
                return View(nvhModel);
            }
        }

    }
}
