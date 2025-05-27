using Microsoft.AspNetCore.Mvc;
using NvhLab6.Models;

namespace NvhLab6.Controllers
{
    public class NvhEmployeeController : Controller
    {
        public static List<NvhEmployee> NvhListEmployee = new List<NvhEmployee>
        {
        new NvhEmployee { NvhId = 1, NvhName = "Nong Van Hung", NvhBirthDay = new DateTime(2005, 8, 14), NvhEmail = "vanhung@example.com", NvhPhone = "0123456789", NvhSalary = 1000, NvhStatus = true },
        new NvhEmployee { NvhId = 2, NvhName = "Trần Thị B", NvhBirthDay = new DateTime(1998, 3, 10), NvhEmail = "thib@example.com", NvhPhone = "0987654321", NvhSalary = 1200, NvhStatus = true },
        new NvhEmployee { NvhId = 3, NvhName = "Lê Văn C", NvhBirthDay = new DateTime(2000, 8, 20), NvhEmail = "vanc@example.com", NvhPhone = "0909090909", NvhSalary = 900, NvhStatus = false },
        new NvhEmployee { NvhId = 4, NvhName = "Phạm Thị D", NvhBirthDay = new DateTime(1995, 1, 30), NvhEmail = "thid@example.com", NvhPhone = "0888888888", NvhSalary = 1100, NvhStatus = true },
        new NvhEmployee { NvhId = 5, NvhName = "Bạn Sinh Viên", NvhBirthDay = new DateTime(2002, 10, 1), NvhEmail = "sinhvien@example.com", NvhPhone = "0777777777", NvhSalary = 950, NvhStatus = true },
    };

        public IActionResult NvhIndex()
        {
            return View(NvhListEmployee);
        }
        public IActionResult NvhCreate()
        {

            return View();  
        }

        public IActionResult NvhCreateSubmit(NvhEmployee nvhEmp)
        {
            nvhEmp.NvhId = NvhListEmployee.Max(e => e.NvhId) + 1;
            NvhListEmployee.Add(nvhEmp);
            return RedirectToAction("NvhIndex");
        }

        [HttpGet]
        public IActionResult NvhEdit(int id)
        {
            var nvhEmp = NvhListEmployee.FirstOrDefault(e => e.NvhId == id);
            if (nvhEmp == null)
                return NotFound();
            return View(nvhEmp);
        }
        public IActionResult NvhEditPUT(NvhEmployee nvhEmp)
        {
            var existing = NvhListEmployee.FirstOrDefault(e => e.NvhId == nvhEmp.NvhId);
            if (existing != null)
            {
                existing.NvhName = nvhEmp.NvhName;
                existing.NvhBirthDay = nvhEmp.NvhBirthDay;
                existing.NvhEmail = nvhEmp.NvhEmail;
                existing.NvhPhone = nvhEmp.NvhPhone;
                existing.NvhSalary = nvhEmp.NvhSalary;
                existing.NvhStatus = nvhEmp.NvhStatus;
            }
            return RedirectToAction("NvhIndex");
        }

        public IActionResult NvhDelete(int id)
        {
            var nvhEmp = NvhListEmployee.FirstOrDefault(e => e.NvhId == id);
            if (nvhEmp != null)
                NvhListEmployee.Remove(nvhEmp);
            return RedirectToAction("NvhIndex");
        }
    }
}

