using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ITS_System.Data;

namespace ITS_System.Models
{
    public class GeneralIssuesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public GeneralIssuesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: GeneralIssues
        public async Task<IActionResult> Index()
        {
              return _context.GeneralIssue != null ? 
                          View(await _context.GeneralIssue.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.GeneralIssue'  is null.");
        }

        // GET: GeneralIssues/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null || _context.GeneralIssue == null)
            {
                return NotFound();
            }

            var generalIssue = await _context.GeneralIssue
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalIssue == null)
            {
                return NotFound();
            }

            return View(generalIssue);
        }

        // GET: GeneralIssues/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralIssues/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Details,TimeStamp")] GeneralIssue generalIssue)
        {
            if (ModelState.IsValid)
            {
                generalIssue.Id = Guid.NewGuid();
                _context.Add(generalIssue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalIssue);
        }

        // GET: GeneralIssues/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null || _context.GeneralIssue == null)
            {
                return NotFound();
            }

            var generalIssue = await _context.GeneralIssue.FindAsync(id);
            if (generalIssue == null)
            {
                return NotFound();
            }
            return View(generalIssue);
        }

        // POST: GeneralIssues/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Id,Details,TimeStamp")] GeneralIssue generalIssue)
        {
            if (id != generalIssue.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalIssue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralIssueExists(generalIssue.Id))
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
            return View(generalIssue);
        }

        // GET: GeneralIssues/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null || _context.GeneralIssue == null)
            {
                return NotFound();
            }

            var generalIssue = await _context.GeneralIssue
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalIssue == null)
            {
                return NotFound();
            }

            return View(generalIssue);
        }

        // POST: GeneralIssues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            if (_context.GeneralIssue == null)
            {
                return Problem("Entity set 'ApplicationDbContext.GeneralIssue'  is null.");
            }
            var generalIssue = await _context.GeneralIssue.FindAsync(id);
            if (generalIssue != null)
            {
                _context.GeneralIssue.Remove(generalIssue);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralIssueExists(Guid id)
        {
          return (_context.GeneralIssue?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
