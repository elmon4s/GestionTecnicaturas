using Back.Fachada.Implementacion;
using Back.Fachada.Interfaz;
using Back.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReporteController : ControllerBase
    {
        private IAplicacion app;
        public ReporteController()
        {
            app = new Aplicacion();
        }

        [HttpGet("/comisiones")]
        public IActionResult GetComisiones()
        {
            try
            {
                return Ok(app.GetComisiones());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/tecnicaturas")]
        public IActionResult GetTecnicaturas()
        {
            try
            {
                return Ok(app.GetTecnicaturas());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        
    }
}
