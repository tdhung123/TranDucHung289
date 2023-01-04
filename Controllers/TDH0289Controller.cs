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
    public class TDH0289Controller : Controller
    {
        private readonly MvcMovieContext _context;

        public TDH0289Controller(MvcMovieContext context)
        {
            _context = context;
        }

        // GET: TDH0289
        public async Task<IActionResult> Index()
        {
              return _context.TDH0289 != null ? 
                          View(await _context.TDH0289.ToListAsync()) :
                          Problem("Entity set 'MvcMovieContext.TDH0289'  is null.");
        }

        // GET: TDH0289/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.TDH0289 == null)
            {
                return NotFound();
            }

            var tDH0289 = await _context.TDH0289
                .FirstOrDefaultAsync(m => m.TDHid == id);
            if (tDH0289 == null)
            {
                return NotFound();
            }

            return View(tDH0289);
        }

        // GET: TDH0289/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TDH0289/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TDHid,TDHName,TDHGender")] TDH0289 tDH0289)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tDH0289);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tDH0289);
        }

        // GET: TDH0289/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.TDH0289 == null)
            {
                return NotFound();
            }

            var tDH0289 = await _context.TDH0289.FindAsync(id);
            if (tDH0289 == null)
            {
                return NotFound();
            }
            return View(tDH0289);
        }

        // POST: TDH0289/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("TDHid,TDHName,TDHGender")] TDH0289 tDH0289)
        {
            if (id != tDH0289.TDHid)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tDH0289);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TDH0289Exists(tDH0289.TDHid))
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
            return View(tDH0289);
        }

        // GET: TDH0289/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.TDH0289 == null)
            {
                return NotFound();
            }

            var tDH0289 = await _context.TDH0289
                .FirstOrDefaultAsync(m => m.TDHid == id);
            if (tDH0289 == null)
            {
                return NotFound();
            }

            return View(tDH0289);
        }

        // POST: TDH0289/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.TDH0289 == null)
            {
                return Problem("Entity set 'MvcMovieContext.TDH0289'  is null.");
            }
            var tDH0289 = await _context.TDH0289.FindAsync(id);
            if (tDH0289 != null)
            {
                _context.TDH0289.Remove(tDH0289);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TDH0289Exists(string id)
        {
          return (_context.TDH0289?.Any(e => e.TDHid == id)).GetValueOrDefault();
        }
    }
}
