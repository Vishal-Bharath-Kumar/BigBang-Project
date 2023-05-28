using Bigbang.Models;
using Bigbang.Repository.BookingDetails;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bigbang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBooking_Services _context;

        public BookingController(IBooking_Services context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Booking_Details>>> GetBookingDetails()
        {
            var th = await _context.GetBookingDetails();
            if (th == null)
            {
                return NotFound();
            }
            return Ok(th);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Booking_Details>> GetBookingDetail(int id)
        {
            var Room = _context.GetBookingDetail(id);
            if (Room == null)
            {
                return NotFound();
            }
            return Ok(Room);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Booking_Details>> PutBookingDetail(int id, Booking_Details booking_Details)
        {
            return Ok(await _context.PutBookingDetail(id, booking_Details));
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<List<Booking_Details>>> PostBookingDetail(Booking_Details booking_Details)
        {
            var item = await _context.PostBookingDetail(booking_Details);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteBookingDetail(int id)
        {
            var room = await _context.DeleteBookingDetail(id);
            if (room == null)
            {
                return NotFound();

            }
            return Ok(room);

        }
    }
}
