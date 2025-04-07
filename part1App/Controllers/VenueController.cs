using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using part1App.Models;

namespace part1App.Controllers
{
    public class VenueController : Controller
    {
        private readonly ApplicationDbContext context;
        public VenueController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task<IActionResult> Index()
        {
            var venues = await context.Venue.ToListAsync();
            return View(venues);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Create(VenueController venue)
        {
            if (ModelState.IsValid)
            {
                
                context.Add(venue);
                await context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venue);
        }


    }
}
