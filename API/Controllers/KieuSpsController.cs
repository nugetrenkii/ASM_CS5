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
    public class KieuSpsController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public KieuSpsController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/KieuSps
        [HttpGet]
        public async Task<ActionResult<IEnumerable<KieuSp>>> GetKieuSps()
        {
          if (_context.KieuSps == null)
          {
              return NotFound();
          }
            return await _context.KieuSps.ToListAsync();
        }

        // GET: api/KieuSps/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KieuSp>> GetKieuSp(Guid id)
        {
          if (_context.KieuSps == null)
          {
              return NotFound();
          }
            var kieuSp = await _context.KieuSps.FindAsync(id);

            if (kieuSp == null)
            {
                return NotFound();
            }

            return kieuSp;
        }

        // PUT: api/KieuSps/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKieuSp(Guid id, KieuSp kieuSp)
        {
            if (id != kieuSp.Id)
            {
                return BadRequest();
            }

            _context.Entry(kieuSp).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KieuSpExists(id))
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

        // POST: api/KieuSps
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KieuSp>> PostKieuSp(KieuSp kieuSp)
        {
          if (_context.KieuSps == null)
          {
              return Problem("Entity set 'FpolyDBContext.KieuSps'  is null.");
          }
            _context.KieuSps.Add(kieuSp);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKieuSp", new { id = kieuSp.Id }, kieuSp);
        }

        // DELETE: api/KieuSps/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKieuSp(Guid id)
        {
            if (_context.KieuSps == null)
            {
                return NotFound();
            }
            var kieuSp = await _context.KieuSps.FindAsync(id);
            if (kieuSp == null)
            {
                return NotFound();
            }

            _context.KieuSps.Remove(kieuSp);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KieuSpExists(Guid id)
        {
            return (_context.KieuSps?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
