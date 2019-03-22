using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Diego.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Diego.Dtos.Catalogos;
using AutoMapper;
using System.Collections.Generic;

namespace Diego.Controllers.Catalogos
{
    [Route("api/catalogos/[controller]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly CatalogosContext _context;
        private readonly IMapper _mapper;
        public ProductosController(CatalogosContext context, IMapper mapper)
        {
            this._context = context;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var datos = await this._context.Productos.Include(p => p.Clasificacion).ToListAsync();
            
            var productos = _mapper.Map<IEnumerable<ProductoToReturnDTO>>(datos);

            return Ok(productos);
        }
    }
}