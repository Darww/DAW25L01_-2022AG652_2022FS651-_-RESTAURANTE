using L12022AG652_2022FS651.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace L12022AG652_2022FS651.Controllers
{
    public class PlatosController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }


        [HttpGet("buscar/{nombre}")]
        public async Task<ActionResult<IEnumerable<Plato>>> BuscarPorNombre(string nombre)
        {
            return await _context.Platos.Where(p => p.NombrePlato.Contains(nombre)).ToListAsync();
        }

    }


}
