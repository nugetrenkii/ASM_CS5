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
    public class ChiTietSalesController : ControllerBase
    {
        private readonly FpolyDBContext _context;

        public ChiTietSalesController(FpolyDBContext context)
        {
            _context = context;
        }

        // GET: api/ChiTietSales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ChiTietSale>>> GetChiTietSales()
        {
          if (_context.ChiTietSales == null)
          {
              return NotFound();
          }
            return await _context.ChiTietSales.ToListAsync();
        }

        // GET: api/ChiTietSales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ChiTietSale>> GetChiTietSale(Guid id)
        {
          if (_context.ChiTietSales == null)
          {
              return NotFound();
          }
            var chiTietSale = await _context.ChiTietSales.FindAsync(id);

            if (chiTietSale == null)
            {
                return NotFound();
            }

            return chiTietSale;
        }

        // PUT: api/ChiTietSales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChiTietSale(Guid id, ChiTietSale chiTietSale)
        {
            if (id != chiTietSale.Id)
            {
                return BadRequest();
            }

            _context.Entry(chiTietSale).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChiTietSaleExists(id))
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

        // POST: api/ChiTietSales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ChiTietSale>> PostChiTietSale(ChiTietSale chiTietSale)
        {
          if (_context.ChiTietSales == null)
          {
              return Problem("Entity set 'FpolyDBContext.ChiTietSales'  is null.");
          }
            _context.ChiTietSales.Add(chiTietSale);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetChiTietSale", new { id = chiTietSale.Id }, chiTietSale);
        }

        // DELETE: api/ChiTietSales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChiTietSale(Guid id)
        {
            if (_context.ChiTietSales == null)
            {
                return NotFound();
            }
            var chiTietSale = await _context.ChiTietSales.FindAsync(id);
            if (chiTietSale == null)
            {
                return NotFound();
            }

            _context.ChiTietSales.Remove(chiTietSale);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ChiTietSaleExists(Guid id)
        {
            return (_context.ChiTietSales?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
