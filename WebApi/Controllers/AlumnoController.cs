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
    public class AlumnoController : ControllerBase
    {
        private IAplicacion app;
        public AlumnoController()
        {
            app = new Aplicacion();
        }

        [HttpPost("/alumno")]
        public IActionResult PostAlumno(Alumno oAlumno)
        {
            try
            {
                if (oAlumno == null)
                    return BadRequest("Se debe ingresar un alumno");
                return Ok(app.SaveAlumno(oAlumno));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPut("/alumno")]
        public IActionResult PutAlumno(Alumno oAlumno)
        {
            try
            {
                if (oAlumno == null)
                    return BadRequest("Se debe ingresar un alumno");
                return Ok(app.UpdateAlumno(oAlumno));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpDelete("/alumno")]
        public IActionResult DeleteAlumno(int nroAlumno)
        {
            try
            {
                return Ok(app.DeleteAlumno(nroAlumno));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/alumno")]
        public IActionResult GetAlumno(int nroAlumno)
        {
            try
            {
                return Ok(app.GetAlumno(nroAlumno));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/lstalumnos")]
        public IActionResult GetAlumnos([FromQuery]List<Parametro> lParam)
        {
            try
            {
                if (lParam == null)
                    return BadRequest("Se deben ingresar parámetros");
                return Ok(app.GetAlumnos(lParam));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
        [HttpGet("/situacioneslab")]
        public IActionResult GetSituacionesLaborales()
        {
            try
            {
                return Ok(app.GetSituacionesLaborales());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
        [HttpGet("/estadosciviles")]
        public IActionResult GetEstadosCiviles()
        {
            try
            {
                return Ok(app.GetEstadosCiviles());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
        [HttpGet("/materiacomision")]
        public IActionResult GetMateriaComision([FromQuery]List<Parametro> lParam)
        {
            try
            {
                if (lParam == null)
                    return BadRequest("Se deben ingresar parámetros");
                return Ok(app.GetMateriaComision(lParam));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
        [HttpGet("/barrios")]
        public IActionResult GetBarrios()
        {
            try
            {
                return Ok(app.GetBarrios());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
    }
}
