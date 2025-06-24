using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NvhLesson10EF.Models;


namespace NvhLesson10EF.Controllers
{
    public class NvhCategoriesController : Controller
    {
        private readonly NvhK23cnt2Lesson10DbContext _context;

        public NvhCategoriesController(NvhK23cnt2Lesson10DbContext context)
        {
            _context = context;
        }

        // GET: NvhCategories
        public async Task<IActionResult> NvhIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NvhCategories/NvhDetails/5
        public async Task<IActionResult> NvhDetails(int? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == nvhId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: NvhCategories/NvhCreate
        public IActionResult NvhCreate()
        {
            return View();
        }

        // POST: NvhCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvhCreate([Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvhIndex));
            }
            return View(category);
        }

        // GET: NvhCategories/NvhEdit/5
        public async Task<IActionResult> NvhEdit(int? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(nvhId);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: NvhCategories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> NvhEdit(int nvhId, [Bind("CateId,CateName,CateStatus")] Category category)
        {
            if (nvhId != category.CateId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(category);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CategoryExists(category.CateId))
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
            return View(category);
        }

        // GET: NvhCategories/NvhDelete/5
        public async Task<IActionResult> NvhDelete(int? nvhId)
        {
            if (nvhId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CateId == nvhId);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NvhCategories/NvhDelete/5
        [HttpPost, ActionName("NvhDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int nvhId)
        {
            var category = await _context.Categories.FindAsync(nvhId);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvhIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CateId == id);
        }
    }
}