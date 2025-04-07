using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using part1App.Models;

namespace part1App.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _context;
        public BookingController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var Booking = await _context.Booking.ToListAsync();
            string? bookings = null;
            return View(Booking);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Add(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.VenueId = _context.Venue.ToList();
            ViewBag.EventId = _context.Event.ToList();
            return View(booking);
        }
        public IActionResult Create()
        {
            return View();
        }
        public async Task<IActionResult> Edit(int id)
        {
            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            ViewBag.VenueId = _context.Venue.ToList();
            ViewBag.EventId = _context.Event.ToList();
            return View(booking);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _context.Update(booking);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.VenueId = _context.Venue.ToList();
            ViewBag.EventId = _context.Event.ToList();
            return View(booking);
        }
        public async Task<IActionResult> Delete(int id)
        {
            var booking = await _context.Booking.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }
            return View(booking);
        }

        
    }
}
