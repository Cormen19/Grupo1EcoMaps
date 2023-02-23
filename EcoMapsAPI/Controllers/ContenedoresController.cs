using EcoMapsAPI.Entidades;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcoMapsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContenedoresController : ControllerBase
    {
        private readonly EcoMapsContext _context;
        public ContenedoresController(EcoMapsContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ContResiduo>>> GetAllContenedoresVidrio()
        {
            var allContenedores = await _context.ContResiduos.Where(c => c.Category.Contains("Vidrio")).Select(c => new
            {
                c.Category,
                c.Latitud,
                c.Longitud
            }).ToListAsync();
            return Ok(allContenedores);
        }
    }
}
