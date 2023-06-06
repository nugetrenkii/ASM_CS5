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
    public class AnhsController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public AnhsController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/Anhs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Anh>>> GetAnhs()
        {
          if (_context.Anhs == null)
          {
              return NotFound();
          }
            return await _context.Anhs.ToListAsync();
        }

        // GET: api/Anhs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Anh>> GetAnh(Guid id)
        {
          if (_context.Anhs == null)
          {
              return NotFound();
          }
            var anh = await _context.Anhs.FindAsync(id);

            if (anh == null)
            {
                return NotFound();
            }

            return anh;
        }

        // PUT: api/Anhs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnh(Guid id, Anh anh)
        {
            if (id != anh.Id)
            {
                return BadRequest();
            }

            _context.Entry(anh).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AnhExists(id))
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

        // POST: api/Anhs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Anh>> PostAnh(Anh anh)
        {
          if (_context.Anhs == null)
          {
              return Problem("Entity set 'FpolyDBContext.Anhs'  is null.");
          }
            _context.Anhs.Add(anh);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAnh", new { id = anh.Id }, anh);
        }

        // DELETE: api/Anhs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnh(Guid id)
        {
            if (_context.Anhs == null)
            {
                return NotFound();
            }
            var anh = await _context.Anhs.FindAsync(id);
            if (anh == null)
            {
                return NotFound();
            }

            _context.Anhs.Remove(anh);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AnhExists(Guid id)
        {
            return (_context.Anhs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
