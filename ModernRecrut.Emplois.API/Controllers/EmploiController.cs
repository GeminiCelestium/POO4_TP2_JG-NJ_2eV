using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.IIS.Core;
using Microsoft.EntityFrameworkCore;
using ModernRecrut.Emplois.API.Data;
using ModernRecrut.Emplois.API.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ModernRecrut.Emplois.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploiController : ControllerBase
    {
        private readonly EmploiContext _context;

        public EmploiController(EmploiContext context)
        {
            _context = context;
        }

        // GET: api/<EmploiController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emploi>>> ObtenirTous()
        {
            return await _context.Emplois.ToListAsync();
        }

        // GET api/<EmploiController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Emploi>> ObtenirUn(int id)
        {
            var emploi = await _context.Emplois.FindAsync(id);

            if (emploi == null)
            {
                return NotFound();
            }

            return emploi;
        }

        // POST api/<EmploiController>
        [HttpPost]
        public async Task<ActionResult<Emploi>> CreerEmploi(Emploi emploi)
        {
            _context.Emplois.Add(emploi);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(emploi.Titre), new { id = emploi.Id }, emploi);
        }

        // PUT api/<EmploiController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEmploi(int id, Emploi emploi)
        {
            if (id != emploi.Id)
            {
                return BadRequest();
            }

            _context.Entry(emploi).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploiExiste(id))
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

        // DELETE api/<EmploiController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> SupprimerEmploi(int id)
        {
            var emploi = await _context.Emplois.FindAsync(id);

            if (emploi == null)
            {
                return NotFound();
            }

            _context.Emplois.Remove(emploi);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmploiExiste(int id)
        {
            return _context.Emplois.Any(e => e.Id == id);
        }
    }
}
