using Microsoft.AspNetCore.Cors;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace NvhLesson08Annotation.Models
{
    public class NvhAccount
    {
        [Key]
        public int NvhId { get; set; }

        [Display(Name="Ho va ten")]
        [Required(ErrorMessage ="Ho va ten khong duoc de trong")]
        [MinLength(6,ErrorMessage ="Hoten it nhat 6 ki tu")]
        [MaxLength(20, ErrorMessage ="HO ten toi da 20 ky tu ")]
        public string NvhFullName { get; set; }

        [Display(Name = "Dia chi email")]
        [Required(ErrorMessage = "Dia hi email khong duoc de trong")]
        [EmailAddress(ErrorMessage ="dia chi email khong dung dinh dang")]
        public string NvhEmail { get; set; }

        [Display(Name = "Số điện thoại")]
        [RegularExpression(@"([0-9]{3})[-. ]?([0-9]{3})[-. ]?([0-9]{4})",
       ErrorMessage = "Số điện thoại không đúng định dạng")]
        [Required(ErrorMessage = "Số điện thoại không được để trống")]
        public string NvhPhone { get; set; }

        [Display(Name = "Dai chi thuong chu")]
        [Required(ErrorMessage="Dia chi thuong chu khong duoc de trong")]
        [StringLength (35,ErrorMessage ="Dia chi khong vuot qua 35 ki tu")]


        public string NvhAddress { get; set; }

        [Display(Name = "Ảnh đại diện")]
        public string NvhAvatar {  get; set; }

        [Display(Name = "Ngày sinh")]
        [Required(ErrorMessage = "Ngày sinh không được để trống")]
        public DateTime NvhBirthDay { get; set; }


        [Display(Name = "Ảnh đại diện")]
        public string NvhGender { get; set; }

        [Display(Name = "Mật khẩu")]
        [DataType(DataType.Password)]
        public string NvhPassword { get; set; }

        [Display(Name = "Link Facebook cá nhân")]
        [Required(ErrorMessage = "Link Facebook không được để trống")]
        [Url(ErrorMessage = "Url phải đúng định dạng bao gồm http hoặc https, tên miền VD: https://facebook.com/itvnsoft")]
        public string NvhFacebook { get; set; }
    }
}
