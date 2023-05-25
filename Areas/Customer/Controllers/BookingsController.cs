using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FitnessApplication.Models;
using ITS_System.Data;
using Microsoft.AspNetCore.Identity;

namespace FitnessApplication.Areas.Customer.Views
{
        [Area("Customer")]

        public class BookingsController : Controller
        {
            private readonly ApplicationDbContext _context;
            private readonly UserManager<IdentityUser> _userManager;

            public BookingsController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
            {
                _context = context;
                _userManager = userManager;
            }

            // GET: Customer/Bookings
            public async Task<IActionResult> Index()
        {
            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (currentUser == null) { return NotFound(); }

            var applicationDbContext = _context.Bookings.Include(b => b.Attendee).Include(b => b.Class).Where(b => b.AttendeeId == currentUser.Id);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: Customer/Bookings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Bookings == null)
            {
                return NotFound();
            }

            var booking = await _context.Bookings
                .Include(b => b.Attendee)
                .Include(b => b.Class)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }

        

        // GET: Customer/Bookings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (_context.Bookings == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Bookings'  is null.");
            }
            var booking = await _context.Bookings.FindAsync(id);
            if (booking != null)
            {
                _context.Bookings.Remove(booking);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        private bool BookingExists(int id)
        {
          return (_context.Bookings?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
