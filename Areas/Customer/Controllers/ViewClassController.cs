using ITS_System.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FitnessApplication.Areas.Customer.Controllers
{
    public class ViewClassController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ViewClassController(ApplicationDbContext context)
        {
            _context = context;
        }


        [Area("Customer")]
        [Authorize(Roles = "Customer")]
        public IActionResult Index()
        {
            var applicationDbContext = _context.Schedule.ToList();
            return View(applicationDbContext);
        }
    }
}
