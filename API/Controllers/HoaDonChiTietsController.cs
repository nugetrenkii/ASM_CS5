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
    public class HoaDonChiTietsController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public HoaDonChiTietsController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/HoaDonChiTiets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<HoaDonChiTiet>>> GetHoaDonChiTiets()
        {
          if (_context.HoaDonChiTiets == null)
          {
              return NotFound();
          }
            return await _context.HoaDonChiTiets.ToListAsync();
        }

        // GET: api/HoaDonChiTiets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<HoaDonChiTiet>> GetHoaDonChiTiet(Guid id)
        {
          if (_context.HoaDonChiTiets == null)
          {
              return NotFound();
          }
            var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);

            if (hoaDonChiTiet == null)
            {
                return NotFound();
            }

            return hoaDonChiTiet;
        }

        // PUT: api/HoaDonChiTiets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHoaDonChiTiet(Guid id, HoaDonChiTiet hoaDonChiTiet)
        {
            if (id != hoaDonChiTiet.Id)
            {
                return BadRequest();
            }

            _context.Entry(hoaDonChiTiet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HoaDonChiTietExists(id))
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

        // POST: api/HoaDonChiTiets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<HoaDonChiTiet>> PostHoaDonChiTiet(HoaDonChiTiet hoaDonChiTiet)
        {
          if (_context.HoaDonChiTiets == null)
          {
              return Problem("Entity set 'FpolyDBContext.HoaDonChiTiets'  is null.");
          }
            _context.HoaDonChiTiets.Add(hoaDonChiTiet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetHoaDonChiTiet", new { id = hoaDonChiTiet.Id }, hoaDonChiTiet);
        }

        // DELETE: api/HoaDonChiTiets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHoaDonChiTiet(Guid id)
        {
            if (_context.HoaDonChiTiets == null)
            {
                return NotFound();
            }
            var hoaDonChiTiet = await _context.HoaDonChiTiets.FindAsync(id);
            if (hoaDonChiTiet == null)
            {
                return NotFound();
            }

            _context.HoaDonChiTiets.Remove(hoaDonChiTiet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HoaDonChiTietExists(Guid id)
        {
            return (_context.HoaDonChiTiets?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
