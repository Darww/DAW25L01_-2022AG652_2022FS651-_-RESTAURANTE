using L12022AG652_2022FS651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L12022AG652_2022FS651.Controllers
{
    public class ClientesController
    {
        [HttpGet("filtrar/{direccion}")]
        public async Task<ActionResult<IEnumerable<Cliente>>> FiltrarPorDireccion(string direccion)
        {
            return await _context.Clientes.Where(c => c.Direccion.Contains(direccion)).ToListAsync();
        }

    }
}
