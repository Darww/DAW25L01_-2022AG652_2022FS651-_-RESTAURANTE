using Microsoft.AspNetCore.Mvc;
using L12022AG652_2022FS651.Models;

namespace L12022AG652_2022FS651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatosController : ControllerBase
    {
        private static List<Plato> platos = new List<Plato>();

        // GET: api/Platos
        [HttpGet]
        public ActionResult<IEnumerable<Plato>> GetPlatos()
        {
            return Ok(platos);
        }

        // GET: api/Platos/5
        [HttpGet("{id}")]
        public ActionResult<Plato> GetPlato(int id)
        {
            var plato = platos.FirstOrDefault(p => p.PlatoId == id);
            if (plato == null)
            {
                return NotFound();
            }
            return Ok(plato);
        }

        // POST: api/Platos
        [HttpPost]
        public ActionResult<Plato> PostPlato([FromBody] Plato plato)
        {
            platos.Add(plato);
            return CreatedAtAction(nameof(GetPlato), new { id = plato.PlatoId }, plato);
        }

        // PUT: api/Platos/5
        [HttpPut("{id}")]
        public IActionResult PutPlato(int id, [FromBody] Plato plato)
        {
            var existingPlato = platos.FirstOrDefault(p => p.PlatoId == id);
            if (existingPlato == null)
            {
                return NotFound();
            }
            existingPlato.NombrePlato = plato.NombrePlato;
            existingPlato.Precio = plato.Precio;
            return NoContent();
        }

        // DELETE: api/Platos/5
        [HttpDelete("{id}")]
        public IActionResult DeletePlato(int id)
        {
            var plato = platos.FirstOrDefault(p => p.PlatoId == id);
            if (plato == null)
            {
                return NotFound();
            }
            platos.Remove(plato);
            return NoContent();
        }
    }
}
