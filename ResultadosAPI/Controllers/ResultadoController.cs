using Microsoft.AspNetCore.Mvc;
using ResultadosAPI.Models;
using ResultadosAPI.Data;


namespace ResultadosAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ResultadoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ResultadoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> GuardarResultado([FromBody] Resultado resultado)
        {
            _context.Resultados.Add(resultado);
            await _context.SaveChangesAsync();

            return Ok(new { mensaje = "Resultado guardado correctamente :3" });
        }
    }
}
