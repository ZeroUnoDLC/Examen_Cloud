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
    public class Tipo_instrumentosController : ControllerBase
    {
        private readonly DbContext _context;

        public Tipo_instrumentosController(DbContext context)
        {
            _context = context;
        }

        // GET: api/Tipo_instrumentos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tipo_instrumento>>> GetTipo_instrumento()
        {
            return await _context.Tipo_instrumentos.ToListAsync();
        }

        // GET: api/Tipo_instrumentos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Tipo_instrumento>> GetTipo_instrumento(int id)
        {
            var tipo_instrumento = await _context.Tipo_instrumentos.FindAsync(id);

            if (tipo_instrumento == null)
            {
                return NotFound();
            }

            return tipo_instrumento;
        }

        // PUT: api/Tipo_instrumentos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTipo_instrumento(int id, Tipo_instrumento tipo_instrumento)
        {
            if (id != tipo_instrumento.Id)
            {
                return BadRequest();
            }

            _context.Entry(tipo_instrumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Tipo_instrumentoExists(id))
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

        // POST: api/Tipo_instrumentos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tipo_instrumento>> PostTipo_instrumento(Tipo_instrumento tipo_instrumento)
        {
            _context.Tipo_instrumentos.Add(tipo_instrumento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTipo_instrumento", new { id = tipo_instrumento.Id }, tipo_instrumento);
        }

        // DELETE: api/Tipo_instrumentos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTipo_instrumento(int id)
        {
            var tipo_instrumento = await _context.Tipo_instrumentos.FindAsync(id);
            if (tipo_instrumento == null)
            {
                return NotFound();
            }

            _context.Tipo_instrumentos.Remove(tipo_instrumento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Tipo_instrumentoExists(int id)
        {
            return _context.Tipo_instrumentos.Any(e => e.Id == id);
        }
    }
}
