using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Diego.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Diego.Controllers.Catalogos
{
    [Route("api/catalogos/[controller]")]
    [ApiController]
    public class ClasificacionesController : ControllerBase
    {
        private CatalogosContext _context;
        public ClasificacionesController(CatalogosContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._context.Clasificaciones.ToListAsync();
            return Ok(datos);
        }
    }
}