using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Nvh2310900042_lab11.Models;

namespace Nvh2310900042_lab11.Controllers
{
    public class NvhEmployeesController : Controller
    {
        private readonly NongVanHung2310900042Context _context;

        public NvhEmployeesController(NongVanHung2310900042Context context)
        {
            _context = context;
        }

        // GET: NvhEmployees
        public async Task<IActionResult> NvhIndex()
        {
            return View(await _context.NvhEmployees.ToListAsync());
        }

        // GET: NvhEmployees/Details/5
        public async Task<IActionResult> NvhDetails(long? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var nvhEmployee = await _context.NvhEmployees
                .FirstOrDefaultAsync(m => m.NvhEmpId == nvhId);
            if (nvhEmployee == null)
            {
                return NotFound();
            }

            return View(nvhEmployee);
        }

        // GET: NvhEmployees/Create
        public IActionResult NvhCreate()
        {
            return View();
        }

        // POST: NvhEmployees/NvhCreate
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvhCreate([Bind("NvhEmpId,NvhEmpName,NvhEmpLevel,NvhEmpStartDate,NvhEmpStatus")] NvhEmployee nvhEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nvhEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvhIndex));
            }
            return View(nvhEmployee);
        }

        // GET: NvhEmployees/Edit/5
        public async Task<IActionResult> NvhEdit(long? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var nvhEmployee = await _context.NvhEmployees.FindAsync(nvhId);
            if (nvhEmployee == null)
            {
                return NotFound();
            }
            return View(nvhEmployee);
        }

        // POST: NvhEmployees/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvhEdit(long nvhId, [Bind("NvhEmpId,NvhEmpName,NvhEmpLevel,NvhEmpStartDate,NvhEmpStatus")] NvhEmployee nvhEmployee)
        {
            if (nvhId != nvhEmployee.NvhEmpId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nvhEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NvhEmployeeExists(nvhEmployee.NvhEmpId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(NvhIndex));
            }
            return View(nvhEmployee);
        }

        // GET: NvhEmployees/Delete/5
        public async Task<IActionResult> NvhDelete(long? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var nvhEmployee = await _context.NvhEmployees
                .FirstOrDefaultAsync(m => m.NvhEmpId == nvhId);
            if (nvhEmployee == null)
            {
                return NotFound();
            }

            return View(nvhEmployee);
        }

        // POST: NvhEmployees/Delete/5
        [HttpPost, ActionName("NvhDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvhDeleteConfirmed(long nvhId)
        {
            var nvhEmployee = await _context.NvhEmployees.FindAsync(nvhId);
            if (nvhEmployee != null)
            {
                _context.NvhEmployees.Remove(nvhEmployee);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvhIndex));
        }

        private bool NvhEmployeeExists(long nvhId)
        {
            return _context.NvhEmployees.Any(e => e.NvhEmpId == nvhId);
        }
    }
}
