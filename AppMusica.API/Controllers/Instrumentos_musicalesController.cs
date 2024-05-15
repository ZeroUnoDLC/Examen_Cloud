using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AppMusica.Entidades;

namespace AppMusica.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Instrumentos_musicalesController : ControllerBase
    {
        private readonly DbContext _context;

        public Instrumentos_musicalesController(DbContext context)
        {
            _context = context;
        }

        // GET: api/Instrumentos_musicales
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Instrumento_musical>>> GetInstrumento_musical()
        {
            return await _context.Instrumentos_musicales.ToListAsync();
        }

        // GET: api/Instrumentos_musicales/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Instrumento_musical>> GetInstrumento_musical(int id)
        {
            var instrumento_musical = await _context.Instrumentos_musicales.FindAsync(id);

            if (instrumento_musical == null)
            {
                return NotFound();
            }

            return instrumento_musical;
        }

        // PUT: api/Instrumentos_musicales/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrumento_musical(int id, Instrumento_musical instrumento_musical)
        {
            if (id != instrumento_musical.Id)
            {
                return BadRequest();
            }

            _context.Entry(instrumento_musical).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Instrumento_musicalExists(id))
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

        // POST: api/Instrumentos_musicales
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Instrumento_musical>> PostInstrumento_musical(Instrumento_musical instrumento_musical)
        {
            _context.Instrumentos_musicales.Add(instrumento_musical);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInstrumento_musical", new { id = instrumento_musical.Id }, instrumento_musical);
        }

        // DELETE: api/Instrumentos_musicales/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrumento_musical(int id)
        {
            var instrumento_musical = await _context.Instrumentos_musicales.FindAsync(id);
            if (instrumento_musical == null)
            {
                return NotFound();
            }

            _context.Instrumentos_musicales.Remove(instrumento_musical);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Instrumento_musicalExists(int id)
        {
            return _context.Instrumentos_musicales.Any(e => e.Id == id);
        }
    }
}
