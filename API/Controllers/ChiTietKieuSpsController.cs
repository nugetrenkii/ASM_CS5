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
    public class ChiTietKieuSpsController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public ChiTietKieuSpsController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/ChiTietKieuSps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietKieuSp>>> GetChiTietKieuSps()
        {
          if (_context.ChiTietKieuSps == null)
          {
              return NotFound();
          }
            return await _context.ChiTietKieuSps.ToListAsync();
        }

        // GET: api/ChiTietKieuSps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietKieuSp>> GetChiTietKieuSp(Guid id)
        {
          if (_context.ChiTietKieuSps == null)
          {
              return NotFound();
          }
            var chiTietKieuSp = await _context.ChiTietKieuSps.FindAsync(id);

            if (chiTietKieuSp == null)
            {
                return NotFound();
            }

            return chiTietKieuSp;
        }

        // PUT: api/ChiTietKieuSps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietKieuSp(Guid id, ChiTietKieuSp chiTietKieuSp)
        {
            if (id != chiTietKieuSp.Id)
            {
                return BadRequest();
            }

            _context.Entry(chiTietKieuSp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietKieuSpExists(id))
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

        // POST: api/ChiTietKieuSps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChiTietKieuSp>> PostChiTietKieuSp(ChiTietKieuSp chiTietKieuSp)
        {
          if (_context.ChiTietKieuSps == null)
          {
              return Problem("Entity set 'FpolyDBContext.ChiTietKieuSps'  is null.");
          }
            _context.ChiTietKieuSps.Add(chiTietKieuSp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChiTietKieuSp", new { id = chiTietKieuSp.Id }, chiTietKieuSp);
        }

        // DELETE: api/ChiTietKieuSps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChiTietKieuSp(Guid id)
        {
            if (_context.ChiTietKieuSps == null)
            {
                return NotFound();
            }
            var chiTietKieuSp = await _context.ChiTietKieuSps.FindAsync(id);
            if (chiTietKieuSp == null)
            {
                return NotFound();
            }

            _context.ChiTietKieuSps.Remove(chiTietKieuSp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChiTietKieuSpExists(Guid id)
        {
            return (_context.ChiTietKieuSps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
