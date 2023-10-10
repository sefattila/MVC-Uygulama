using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using _10_API_HospialProject_Erdinc_.Contexts;
using _10_API_HospialProject_Erdinc_.Entities;

namespace _10_API_HospialProject_Erdinc_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HastaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HastaController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Hasta
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Hasta>>> GetHastalars()
        {
          if (_context.Hastalars == null)
          {
              return NotFound();
          }
            return await _context.Hastalars.ToListAsync();
        }

        // GET: api/Hasta/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Hasta>> GetHasta(string id)
        {
          if (_context.Hastalars == null)
          {
              return NotFound();
          }
            var hasta = await _context.Hastalars.FindAsync(id);

            if (hasta == null)
            {
                return NotFound();
            }

            return hasta;
        }

        // PUT: api/Hasta/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHasta(string id, Hasta hasta)
        {
            if (id != hasta.Id)
            {
                return BadRequest();
            }

            _context.Entry(hasta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HastaExists(id))
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

        // POST: api/Hasta
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Hasta>> PostHasta(Hasta hasta)
        {
          if (_context.Hastalars == null)
          {
              return Problem("Entity set 'AppDbContext.Hastalars'  is null.");
          }
            _context.Hastalars.Add(hasta);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (HastaExists(hasta.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetHasta", new { id = hasta.Id }, hasta);
        }

        // DELETE: api/Hasta/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHasta(string id)
        {
            if (_context.Hastalars == null)
            {
                return NotFound();
            }
            var hasta = await _context.Hastalars.FindAsync(id);
            if (hasta == null)
            {
                return NotFound();
            }

            _context.Hastalars.Remove(hasta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool HastaExists(string id)
        {
            return (_context.Hastalars?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
