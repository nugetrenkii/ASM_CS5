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
    public class PtthanhToansController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public PtthanhToansController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/PtthanhToans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PtthanhToan>>> GetPtthanhToans()
        {
          if (_context.PtthanhToans == null)
          {
              return NotFound();
          }
            return await _context.PtthanhToans.ToListAsync();
        }

        // GET: api/PtthanhToans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PtthanhToan>> GetPtthanhToan(Guid id)
        {
          if (_context.PtthanhToans == null)
          {
              return NotFound();
          }
            var ptthanhToan = await _context.PtthanhToans.FindAsync(id);

            if (ptthanhToan == null)
            {
                return NotFound();
            }

            return ptthanhToan;
        }

        // PUT: api/PtthanhToans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPtthanhToan(Guid id, PtthanhToan ptthanhToan)
        {
            if (id != ptthanhToan.Id)
            {
                return BadRequest();
            }

            _context.Entry(ptthanhToan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PtthanhToanExists(id))
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

        // POST: api/PtthanhToans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PtthanhToan>> PostPtthanhToan(PtthanhToan ptthanhToan)
        {
          if (_context.PtthanhToans == null)
          {
              return Problem("Entity set 'FpolyDBContext.PtthanhToans'  is null.");
          }
            _context.PtthanhToans.Add(ptthanhToan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPtthanhToan", new { id = ptthanhToan.Id }, ptthanhToan);
        }

        // DELETE: api/PtthanhToans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePtthanhToan(Guid id)
        {
            if (_context.PtthanhToans == null)
            {
                return NotFound();
            }
            var ptthanhToan = await _context.PtthanhToans.FindAsync(id);
            if (ptthanhToan == null)
            {
                return NotFound();
            }

            _context.PtthanhToans.Remove(ptthanhToan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PtthanhToanExists(Guid id)
        {
            return (_context.PtthanhToans?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
