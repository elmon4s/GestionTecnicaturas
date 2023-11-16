using Back.Dominio;
using Back.Fachada.Implementacion;
using Back.Fachada.Interfaz;
using Back.Login;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private IAplicacion app;

        public UsuarioController()
        {
            app = new Aplicacion();
        }

        [HttpPost("/usuario")]
        public IActionResult PostUsuario(Usuario oUsuario)
        {
            try
            {
                if (oUsuario == null)
                    return BadRequest("Se debe ingresar un usuario");
                return Ok(app.SaveUsuario(oUsuario));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPost("/verificar")]
        public IActionResult GetAuth(Usuario oUsuario) 
        {
            try
            {
                if (oUsuario == null)
                    return BadRequest("Se debe ingresar un usuario");
                return Ok(app.CheckUsuario(oUsuario));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPost("/verificarnombre")]
        public IActionResult GetUsername(Usuario oUsuario)
        {
            try
            {
                if (oUsuario == null)
                    return BadRequest("Se debe ingresar un usuario");
                return Ok(app.CheckNombreUsuario(oUsuario));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
    }
}
