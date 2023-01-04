using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TranDucHung289.Models;

namespace TranDucHung289.Controllers
{
    public class CompanyTDH289Controller : Controller
    {
        private readonly MvcMovieContext _context;
        private StringProcessTDH289 strPro = new StringProcessTDH289();


        public CompanyTDH289Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: CompanyTDH289
        public async Task<IActionResult> Index()
        {
              return _context.CompanyTDH289 != null ? 
                          View(await _context.CompanyTDH289.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.CompanyTDH289'  is null.");
        }

        // GET: CompanyTDH289/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.CompanyTDH289 == null)
            {
                return NotFound();
            }

            var companyTDH289 = await _context.CompanyTDH289
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyTDH289 == null)
            {
                return NotFound();
            }

            return View(companyTDH289);
        }

        // GET: CompanyTDH289/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyTDH289/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyId,CompanyName")] CompanyTDH289 companyTDH289)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyTDH289);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyTDH289);
        }

        // GET: CompanyTDH289/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.CompanyTDH289 == null)
            {
                return NotFound();
            }

            var companyTDH289 = await _context.CompanyTDH289.FindAsync(id);
            if (companyTDH289 == null)
            {
                return NotFound();
            }
            return View(companyTDH289);
        }

        // POST: CompanyTDH289/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyId,CompanyName")] CompanyTDH289 companyTDH289)
        {
            if (id != companyTDH289.CompanyId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyTDH289);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyTDH289Exists(companyTDH289.CompanyId))
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
            return View(companyTDH289);
        }

        // GET: CompanyTDH289/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.CompanyTDH289 == null)
            {
                return NotFound();
            }

            var companyTDH289 = await _context.CompanyTDH289
                .FirstOrDefaultAsync(m => m.CompanyId == id);
            if (companyTDH289 == null)
            {
                return NotFound();
            }

            return View(companyTDH289);
        }

        // POST: CompanyTDH289/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.CompanyTDH289 == null)
            {
                return Problem("Entity set 'MvcMovieContext.CompanyTDH289'  is null.");
            }
            var companyTDH289 = await _context.CompanyTDH289.FindAsync(id);
            if (companyTDH289 != null)
            {
                _context.CompanyTDH289.Remove(companyTDH289);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyTDH289Exists(string id)
        {
          return (_context.CompanyTDH289?.Any(e => e.CompanyId == id)).GetValueOrDefault();
        }
    }
}
