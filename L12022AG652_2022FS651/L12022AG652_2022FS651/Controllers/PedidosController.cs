using Microsoft.AspNetCore.Mvc;
using L12022AG652_2022FS651.Models;

namespace L12022AG652_2022FS651.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private static List<Pedido> pedidos = new List<Pedido>();

        // GET: api/Pedidos
        [HttpGet]
        public ActionResult<IEnumerable<Pedido>> GetPedidos()
        {
            return Ok(pedidos);
        }

        // GET: api/Pedidos/5
        [HttpGet("{id}")]
        public ActionResult<Pedido> GetPedido(int id)
        {
            var pedido = pedidos.FirstOrDefault(p => p.PedidoId == id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        // POST: api/Pedidos
        [HttpPost]
        public ActionResult<Pedido> PostPedido([FromBody] Pedido pedido)
        {
            pedidos.Add(pedido);
            return CreatedAtAction(nameof(GetPedido), new { id = pedido.PedidoId }, pedido);
        }

        // PUT: api/Pedidos/5
        [HttpPut("{id}")]
        public IActionResult PutPedido(int id, [FromBody] Pedido pedido)
        {
            var existingPedido = pedidos.FirstOrDefault(p => p.PedidoId == id);
            if (existingPedido == null)
            {
                return NotFound();
            }
            existingPedido.MotoristaId = pedido.MotoristaId;
            existingPedido.ClienteId = pedido.ClienteId;
            existingPedido.PlatoId = pedido.PlatoId;
            existingPedido.Cantidad = pedido.Cantidad;
            existingPedido.Precio = pedido.Precio;
            return NoContent();
        }

        // DELETE: api/Pedidos/5
        [HttpDelete("{id}")]
        public IActionResult DeletePedido(int id)
        {
            var pedido = pedidos.FirstOrDefault(p => p.PedidoId == id);
            if (pedido == null)
            {
                return NotFound();
            }
            pedidos.Remove(pedido);
            return NoContent();
        }
    }
}