namespace NvhLesson02.Models
{
    public class NvhSanPham
    {
            public int NvhId { get; set; }
            public string NvhTenSanPham { get; set; }
            public int NvhGiaGoc { get; set; }
            public int NvhGiaMoi { get; set; }
            public string NvhMoTa { get; set; }
            public string NvhAnh { get; set; }
            public string NvhTrangThai { get; set; }
            public DateTime NvhNgayDang { get; set; }
            public int NvhDanhMucId { get; set; }
        
    }
}
