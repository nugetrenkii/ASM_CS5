﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _1.DAL.Context;
using _1.DAL.DomainClass;
using ASM_CS5.IRepositories;
using ASM_CS5.Repositories;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KhachHangController : ControllerBase
    {
        private readonly FpolyDBContext _context;
        private IAllRepositories<KhachHang> _repos;

        public KhachHangController(FpolyDBContext context)
        {
            _context = context;
            _repos = new AllRepositories<KhachHang>();
        }

        // GET: api/KhachHang
        [HttpGet("GetKH")]
        public async Task<ActionResult<IEnumerable<KhachHang>>> GetKhachHangs()
        {
          if (_context.KhachHangs == null)
          {
              return NotFound();
          }
            return await _context.KhachHangs.ToListAsync();
        }

        // GET: api/KhachHang/5
        [HttpGet("{id}")]
        public async Task<ActionResult<KhachHang>> GetKhachHang(Guid id)
        {
          if (_context.KhachHangs == null)
          {
              return NotFound();
          }
            var khachHang = await _context.KhachHangs.FindAsync(id);

            if (khachHang == null)
            {
                return NotFound();
            }

            return khachHang;
        }

        // PUT: api/KhachHang/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKhachHang(Guid id, KhachHang khachHang)
        {
            if (id != khachHang.Id)
            {
                return BadRequest();
            }

            _context.Entry(khachHang).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KhachHangExists(id))
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

        // POST: api/KhachHang
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<KhachHang>> PostKhachHang(KhachHang khachHang)
        {
          if (_context.KhachHangs == null)
          {
              return Problem("Entity set 'FpolyDBContext.KhachHangs'  is null.");
          }
            _context.KhachHangs.Add(khachHang);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKhachHang", new { id = khachHang.Id }, khachHang);
        }

        // DELETE: api/KhachHang/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteKhachHang(Guid id)
        {
            if (_context.KhachHangs == null)
            {
                return NotFound();
            }
            var khachHang = await _context.KhachHangs.FindAsync(id);
            if (khachHang == null)
            {
                return NotFound();
            }

            _context.KhachHangs.Remove(khachHang);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool KhachHangExists(Guid id)
        {
            return (_context.KhachHangs?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
