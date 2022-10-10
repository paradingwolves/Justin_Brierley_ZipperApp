using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ZipperApp.Data;
using ZipperApp.Models;

namespace ZipperApp.Controllers
{
    public class ZippersController : Controller
    {
        private readonly ZipperAppContext _context;

        public ZippersController(ZipperAppContext context)
        {
            _context = context;
        }

        // GET: Zippers
        public async Task<IActionResult> Index(string zipperCategory, string searchString)
        {
            // Use LINQ to get list of categories.
            IQueryable<string> categoryQuery = from z in _context.Zipper
                                            orderby z.Category
                                            select z.Category;

            var zippers = from z in _context.Zipper
                         select z;

            if (!string.IsNullOrEmpty(searchString))
            {
                zippers = zippers.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(zipperCategory))
            {
                zippers = zippers.Where(x => x.Category == zipperCategory);
            }

            var zipperCategoryVM = new ZipperCategoryViewModel
            {
                Category = new SelectList(await categoryQuery.Distinct().ToListAsync()),
                Zippers = await zippers.ToListAsync()
            };

            return View(zipperCategoryVM);
        }

        // GET: Zippers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper
                .FirstOrDefaultAsync(z => z.Id == id);
            if (zipper == null)
            {
                return NotFound();
            }

            return View(zipper);
        }

        // GET: Zippers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Zippers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Category,Material,TeethSize,Colour,Price")] Zipper zipper)
        {
            if (ModelState.IsValid)
            {
                _context.Add(zipper);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(zipper);
        }

        // GET: Zippers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper.FindAsync(id);
            if (zipper == null)
            {
                return NotFound();
            }
            return View(zipper);
        }

        // POST: Zippers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,Material,TeethSize,Colour,Price")] Zipper zipper)
        {
            if (id != zipper.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(zipper);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ZipperExists(zipper.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(zipper);
        }

        // GET: Zippers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var zipper = await _context.Zipper
                .FirstOrDefaultAsync(m => m.Id == id);
            if (zipper == null)
            {
                return NotFound();
            }

            return View(zipper);
        }

        // POST: Zippers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var zipper = await _context.Zipper.FindAsync(id);
            _context.Zipper.Remove(zipper);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ZipperExists(int id)
        {
            return _context.Zipper.Any(e => e.Id == id);
        }
    }
}
