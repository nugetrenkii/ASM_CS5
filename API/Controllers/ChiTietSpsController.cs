using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _1.DAL.Context;
using _1.DAL.DomainClass;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChiTietSpsController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public ChiTietSpsController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/ChiTietSps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietSp>>> GetChiTietSps()
        {
          if (_context.ChiTietSps == null)
          {
              return NotFound();
          }
            return await _context.ChiTietSps.ToListAsync();
        }

        // GET: api/ChiTietSps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietSp>> GetChiTietSp(Guid id)
        {
          if (_context.ChiTietSps == null)
          {
              return NotFound();
          }
            var chiTietSp = await _context.ChiTietSps.FindAsync(id);

            if (chiTietSp == null)
            {
                return NotFound();
            }

            return chiTietSp;
        }

        // PUT: api/ChiTietSps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietSp(Guid id, ChiTietSp chiTietSp)
        {
            if (id != chiTietSp.Id)
            {
                return BadRequest();
            }

            _context.Entry(chiTietSp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietSpExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/ChiTietSps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChiTietSp>> PostChiTietSp(ChiTietSp chiTietSp)
        {
          if (_context.ChiTietSps == null)
          {
              return Problem("Entity set 'FpolyDBContext.ChiTietSps'  is null.");
          }
            _context.ChiTietSps.Add(chiTietSp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChiTietSp", new { id = chiTietSp.Id }, chiTietSp);
        }

        // DELETE: api/ChiTietSps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChiTietSp(Guid id)
        {
            if (_context.ChiTietSps == null)
            {
                return NotFound();
            }
            var chiTietSp = await _context.ChiTietSps.FindAsync(id);
            if (chiTietSp == null)
            {
                return NotFound();
            }

            _context.ChiTietSps.Remove(chiTietSp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChiTietSpExists(Guid id)
        {
            return (_context.ChiTietSps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
