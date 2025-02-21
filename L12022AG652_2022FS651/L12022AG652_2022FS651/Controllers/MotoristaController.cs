using Microsoft.AspNetCore.Mvc;
using L12022AG652_2022FS651.Models;

namespace L12022AG652_2022FS651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MotoristasController : ControllerBase
    {
        private static List<Motorista> motoristas = new List<Motorista>();

        // GET: api/Motoristas
        [HttpGet]
        public ActionResult<IEnumerable<Motorista>> GetMotoristas()
        {
            return Ok(motoristas);
        }

        // GET: api/Motoristas/5
        [HttpGet("{id}")]
        public ActionResult<Motorista> GetMotorista(int id)
        {
            var motorista = motoristas.FirstOrDefault(m => m.MotoristaId == id);
            if (motorista == null)
            {
                return NotFound();
            }
            return Ok(motorista);
        }

        // POST: api/Motoristas
        [HttpPost]
        public ActionResult<Motorista> PostMotorista([FromBody] Motorista motorista)
        {
            motoristas.Add(motorista);
            return CreatedAtAction(nameof(GetMotorista), new { id = motorista.MotoristaId }, motorista);
        }

        // PUT: api/Motoristas/5
        [HttpPut("{id}")]
        public IActionResult PutMotorista(int id, [FromBody] Motorista motorista)
        {
            var existingMotorista = motoristas.FirstOrDefault(m => m.MotoristaId == id);
            if (existingMotorista == null)
            {
                return NotFound();
            }
            existingMotorista.NombreMotorista = motorista.NombreMotorista;
            return NoContent();
        }

        // DELETE: api/Motoristas/5
        [HttpDelete("{id}")]
        public IActionResult DeleteMotorista(int id)
        {
            var motorista = motoristas.FirstOrDefault(m => m.MotoristaId == id);
            if (motorista == null)
            {
                return NotFound();
            }
            motoristas.Remove(motorista);
            return NoContent();
        }
    }
}