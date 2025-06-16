using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NvhLesson09EF.Models;


namespace NvhLesson09EF.Controllers
{
    public class NvhCategoriesController : Controller
    {
        private readonly NvhBookStoreContext _context;

        public NvhCategoriesController(NvhBookStoreContext context)
        {
            _context = context;
        }

        // GET: NvhCategories
        public async Task<IActionResult> NvhIndex()
        {
            return View(await _context.Categories.ToListAsync());
        }

        // GET: NvhCategories/Details/5
        public async Task<IActionResult> NvhDetails(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // GET: NvhCategories/Create
        public IActionResult NvhCreate()
        {
            return View();
        }

        // POST: NvhCategories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CategoryId,CategoryName")] Category category)
        {
            if (ModelState.IsValid)
            {
                _context.Add(category);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(NvhIndex));
            }
            return View(category);
        }

        // GET: NvhCategories/Edit/5
        public async Task<IActionResult> NvhEdit(int? NvhId)
        {
            if (NvhId == null)
            {
                return NotFound();
            }

            var category = await _context.Categories.FindAsync(NvhId);
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
        public async Task<IActionResult> Edit(int NvhId, [Bind("CategoryId,CategoryName")] Category category)
        {
            if (NvhId != category.CategoryId)
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
                    if (!CategoryExists(category.CategoryId))
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

        // GET: NvhCategories/Delete/5
        public async Task<IActionResult> NvhDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var category = await _context.Categories
                .FirstOrDefaultAsync(m => m.CategoryId == id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST: NvhCategories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var category = await _context.Categories.FindAsync(id);
            if (category != null)
            {
                _context.Categories.Remove(category);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(NvhIndex));
        }

        private bool CategoryExists(int id)
        {
            return _context.Categories.Any(e => e.CategoryId == id);
        }
    }
}