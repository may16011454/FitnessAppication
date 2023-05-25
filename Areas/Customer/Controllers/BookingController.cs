using FitnessApplication.Models;
using ITS_System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace FitnessApplication.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Authorize(Roles = "Customer")]
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public BookingController(ApplicationDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index(string searchString)
        {
            var classSchedules = from c in _context.Schedule
                                 select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                classSchedules = classSchedules.Where(s => s.Instructor.Email.Contains(searchString) || s.DateTime.ToString().Contains(searchString));
            }

            return View(await classSchedules.Include("Instructor").Include("Room").OrderBy(s => s.DateTime).ToListAsync());
        }

        public async Task<IActionResult> Book(int Id)
        {
            var currentUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (currentUser == null)
            {
                return NotFound();
            }

            Booking book = new Booking();

            book.ClassId = Id;
            book.AttendeeId = currentUser.Id;
            book.TimeStamp = DateTime.Now;
            book.Status = Enums.BookingStatus.Active;
            book.Attendee = currentUser;

            var currentClass = await _context.Schedule.Include(s => s.Attendees).Where(s => s.Id == Id).FirstOrDefaultAsync();

            if (currentClass == null)
            {
                return NotFound();
            }

            bool dounblebook = currentClass.Attendees.Any(a => a.AttendeeId == currentUser.Id);

            if (dounblebook)
            {
                return RedirectToAction("Index", "Bookings");
            }

            book.Class = currentClass;

            currentClass.Attendees.Add(book);
            currentClass.AvailableSpaces = currentClass.MaxNumberOfBookings - currentClass.Attendees.Count();
            _context.Schedule.Update(currentClass);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
