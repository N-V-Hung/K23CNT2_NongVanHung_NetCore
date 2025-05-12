using Microsoft.AspNetCore.Mvc;
using NvhLesson02.Models;

namespace NvhLesson02.Controllers
{
    public class NvhSanPhamConTroller : Controller
    {
        // Dữ liệu mẫu
        private static List<NvhDanhMuc> nvhDanhMucs = new List<NvhDanhMuc>
    {
        new NvhDanhMuc{ NvhId = 1, NvhTenDanhMuc = "Quần Áo" },
        new NvhDanhMuc{ NvhId = 2, NvhTenDanhMuc = "Túi xách" },
        // Thêm các danh mục khác...
    };

        private static List<NvhSanPham> nvhSanPhams = new List<NvhSanPham>
    {
        new NvhSanPham{ NvhId = 1, NvhTenSanPham = "Bộ đồ bơi cho trẻ em nam", NvhGiaGoc = 50000, NvhGiaMoi = 35000,
                     NvhMoTa = "Lorem ipsum...", NvhAnh = "/images/boi1.jpg", NvhTrangThai = "Còn hàng",
                     NvhNgayDang = DateTime.Parse("2021-07-15"), NvhDanhMucId = 1 },
        // Thêm các sản phẩm khác...
    };

        public IActionResult Index(int? Nvhid)
        {
            var nvhdsSanPham = Nvhid == null ? nvhSanPhams : nvhSanPhams.Where(nvhsp => nvhsp.NvhDanhMucId == Nvhid);
            ViewBag.NvhDanhMuc = nvhDanhMucs;
            return View(nvhdsSanPham);
        }

        public IActionResult NvhChiTiet(int Nvhid)
        {
            var nvhsp = nvhSanPhams.FirstOrDefault(x => x.NvhId == Nvhid);
            if (nvhsp == null) return NotFound();
            return View(nvhsp);
        }
    }
}

