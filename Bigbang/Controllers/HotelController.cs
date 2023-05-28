using Bigbang.Models;
using Bigbang.Repository.Hotels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bigbang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotels_Services _context;

        public HotelController(IHotels_Services context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hotel>>> GetHotels()
        {
            var th = await _context.GetHotels();
            if (th == null)
            {
                return NotFound();
            }
            return Ok(th);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hotel>> GetHotel(int id)
        {
            var hotel = _context.GetHotel(id);
            if (hotel == null)
            {
                return NotFound();
            }
            return Ok(hotel);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize]
        public async Task<ActionResult<Hotel>> PutHotel(int id, Hotel hotel)
        {
            return Ok(await _context.PutHotel(id, hotel));
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [Authorize]
        public async Task<ActionResult<List<Hotel>>> PostHotel(Hotel hotel)
        {
            var item = await _context.PostHotel(hotel);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            var hotel = await _context.DeleteHotel(id);
            if (hotel == null)
            {
                return NotFound();

            }
            return Ok(hotel);

        }
        //GET : Count of Available Rooms
        [HttpGet("{hotelId}/rooms/count")]
        public async Task<IActionResult> GetAvailableRoomCount(int hotelId)
        {
            var availableRoomCount = await _context.GetAvailableRoomCount(hotelId);
            return Ok(availableRoomCount);
        }

        //GET: Filter Hotels Based on Location
        [HttpGet]
        public async Task<IActionResult> GetHotels(string location)
        {
            var filteredHotels = await _context.FilterHotels(location);
            return Ok(filteredHotels);
        }

    }
}



