using Microsoft.AspNetCore.Mvc;
using L12022AG652_2022FS651.Models;

namespace L12022AG652_2022FS651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new List<Cliente>();

        // GET: api/Clientes
        [HttpGet]
        public ActionResult<IEnumerable<Cliente>> GetClientes()
        {
            return Ok(clientes);
        }

        // GET: api/Clientes/5
        [HttpGet("{id}")]
        public ActionResult<Cliente> GetCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.ClienteId == id);
            if (cliente == null)
            {
                return NotFound();
            }
            return Ok(cliente);
        }

        // POST: api/Clientes
        [HttpPost]
        public ActionResult<Cliente> PostCliente([FromBody] Cliente cliente)
        {
            clientes.Add(cliente);
            return CreatedAtAction(nameof(GetCliente), new { id = cliente.ClienteId }, cliente);
        }

        // PUT: api/Clientes/5
        [HttpPut("{id}")]
        public IActionResult PutCliente(int id, [FromBody] Cliente cliente)
        {
            var existingCliente = clientes.FirstOrDefault(c => c.ClienteId == id);
            if (existingCliente == null)
            {
                return NotFound();
            }
            existingCliente.NombreCliente = cliente.NombreCliente;
            existingCliente.Direccion = cliente.Direccion;
            return NoContent();
        }

        // DELETE: api/Clientes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCliente(int id)
        {
            var cliente = clientes.FirstOrDefault(c => c.ClienteId == id);
            if (cliente == null)
            {
                return NotFound();
            }
            clientes.Remove(cliente);
            return NoContent();
        }
    }
}