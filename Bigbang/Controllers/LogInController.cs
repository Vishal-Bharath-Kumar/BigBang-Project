using Bigbang.Models;
using Bigbang.Repository.LogIns;
using Bigbang.Repository.Rooms;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bigbang.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogInController : ControllerBase
    {
        private readonly ILogIn_Services _context;

        public LogInController(ILogIn_Services context)
        {
            _context = context;
        }

        // GET: api/Hotels
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LogIn>>> GetLogIns()
        {
            var th = await _context.GetLogIns();
            if (th == null)
            {
                return NotFound();
            }
            return Ok(th);
        }

        // GET: api/Hotels/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LogIn>> GetLogIn(int id)
        {
            var log = _context.GetLogIn(id);
            if (log == null)
            {
                return NotFound();
            }
            return Ok(log);
        }

        // PUT: api/Hotels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<LogIn>> PutRoom(int id, LogIn logIn)
        {
            return Ok(await _context.PutLogIn(id, logIn));
        }

        // POST: api/Hotels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<List<LogIn>>> PostRoom(LogIn logIn)
        {
            var item = await _context.PostLogIn(logIn);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        // DELETE: api/Hotels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLogIn(int id)
        {
            var log = await _context.DeleteLogIn(id);
            if (log == null)
            {
                return NotFound();

            }
            return Ok(log);

        }
    }
}
