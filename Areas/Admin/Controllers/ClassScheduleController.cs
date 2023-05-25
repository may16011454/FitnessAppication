using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessApplication.Models;
using ITS_System.Data;
using Microsoft.AspNetCore.Authorization;

namespace FitnessApplication.Areas.Admin
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]

    public class ClassScheduleController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ClassScheduleController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Admin/ClassSchedule
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.Schedule.Include(c => c.Room);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Admin/ClassSchedule/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule
                .Include(c => c.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classSchedule == null)
            {
                return NotFound();
            }

            return View(classSchedule);
        }

        // GET: Admin/ClassSchedule/Create
        public IActionResult Create()
        {
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name");
            return View();
        }

        // POST: Admin/ClassSchedule/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create ([Bind("Name,Id,DateTime,InstructorId,MaxNumberOfBookings,RoomId,Status")] ClassSchedule classSchedule)
        {
            classSchedule.Room =  await _context.Rooms.FindAsync(classSchedule.RoomId);
            classSchedule.Instructor =  await _context.Users.FindAsync(classSchedule.InstructorId);

            if(classSchedule.InstructorId != null && 
                classSchedule.DateTime != null && 
                classSchedule.Status != null && 
                classSchedule.MaxNumberOfBookings > 0 &&
                classSchedule.RoomId != null)
            { 
                _context.Add(classSchedule);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", classSchedule.RoomId);
            return View(classSchedule);
        }

        // GET: Admin/ClassSchedule/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule.FindAsync(id);
            if (classSchedule == null)
            {
                return NotFound();
            }
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", classSchedule.RoomId);
            return View(classSchedule);
        }

        // POST: Admin/ClassSchedule/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DateTime,MaxNumberOfBookings,RoomId,Status")] ClassSchedule classSchedule)
        {
            if (id != classSchedule.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(classSchedule);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClassScheduleExists(classSchedule.Id))
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
            ViewData["InstructorId"] = new SelectList(_context.Users, "Id", "Email");
            ViewData["RoomId"] = new SelectList(_context.Rooms, "Id", "Name", classSchedule.RoomId);
            return View(classSchedule);
        }

        // GET: Admin/ClassSchedule/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Schedule == null)
            {
                return NotFound();
            }

            var classSchedule = await _context.Schedule
                .Include(c => c.Room)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (classSchedule == null)
            {
                return NotFound();
            }

            return View(classSchedule);
        }

        // POST: Admin/ClassSchedule/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Schedule == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Schedule'  is null.");
            }
            var classSchedule = await _context.Schedule.FindAsync(id);
            if (classSchedule != null)
            {
                _context.Schedule.Remove(classSchedule);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClassScheduleExists(int id)
        {
          return (_context.Schedule?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
