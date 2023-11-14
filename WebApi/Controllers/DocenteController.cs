using Back.Datos;
using Back.Dominio;
using Back.Fachada.Implementacion;
using Back.Fachada.Interfaz;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private IAplicacion app;
        public DocenteController()
        {
            app = new Aplicacion();
        }

        [HttpPost("/docente")]
        public IActionResult PostDocente(Docente oDocente)
        {
            try
            {
                if (oDocente == null)
                    return BadRequest("Se debe ingresar un docente");
                return Ok(app.SaveDocente(oDocente));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPut("/docente")]
        public IActionResult PutDocente(Docente oDocente)
        {
            try
            {
                if (oDocente == null)
                    return BadRequest("Se debe ingresar un docente");
                return Ok(app.UpdateDocente(oDocente));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpDelete("/docente")]
        public IActionResult DeleteDocente(int nroDocente)
        {
            try
            {
                if (nroDocente == null)
                    return BadRequest("Se debe ingresar un examen");
                return Ok(app.DeleteDocente(nroDocente));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/lstdocentes")]
        public IActionResult GetDocentes(string? nombre, int barrioId, int tituloId)
        {
            try
            {
                List<Parametro> lParam = new List<Parametro>();
                lParam.Add(new Parametro("@nombre", nombre ?? ""));
                lParam.Add(new Parametro("@barrio", barrioId));
                lParam.Add(new Parametro("@titulo", tituloId));

                return Ok(app.GetDocentes(lParam));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/docente")]
        public IActionResult GetDocente(int nroDocente)
        {
            try
            {
                if (nroDocente == null)
                    return BadRequest("Se debe ingresar un examen");
                return Ok(app.GetDocente(nroDocente));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/titulos")]
        public IActionResult GetTitulos()
        {
            try
            {
                return Ok(app.GetTitulos());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
    }
}
