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
    public class ExamenController : ControllerBase
    {
        private IAplicacion app;
        public ExamenController()
        {
            app = new Aplicacion();
        }

        [HttpGet("/proximoexamen")]
        public IActionResult GetProximoExamen()
        {
            try
            {
                return Ok(app.GetProximoExamen());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPost("/examen")]
        public IActionResult PostExamen(Examen oExamen)
        {
            try
            {
                if (oExamen == null)
                    return BadRequest("Se debe ingresar un examen");
                return Ok(app.SaveExamen(oExamen));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPut("/examen")]
        public IActionResult PutExamen(Examen oExamen)
        {
            try
            {
                if (oExamen == null)
                    return BadRequest("Se debe ingresar un examen");
                return Ok(app.UpdateExamen(oExamen));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpDelete("/examen")]
        public IActionResult DeleteExamen([FromQuery(Name = "nroExamen")] int nroExamen)
        {
            try
            {
                return Ok(app.DeleteExamen(nroExamen));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/examen/{nroExamen}")]
        public IActionResult GetExamen(int nroExamen)
        {
            try
            {
                if (nroExamen == null)
                    return BadRequest("Se debe ingresar un número de examen");
                return Ok(app.GetExamen(nroExamen));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpPost("/lstexamenes")]
        public IActionResult GetExamenes([FromBody] List<Parametro> lParam)
        {
            try
            {
                if (lParam == null)
                    return BadRequest("Se deben ingresar parámetros");

                foreach (var parametro in lParam)
                {
                    if (parametro.Valor != null)
                    {
                        if (int.TryParse(parametro.Valor.ToString(), out _))
                        {
                            int.TryParse(parametro.Valor.ToString(), out int valorComoInt);
                            parametro.Valor = valorComoInt;
                        }
                        else if (DateTime.TryParse(parametro.Valor.ToString(), out DateTime valorComoDateTime))
                        {
                            parametro.Valor = valorComoDateTime.ToString("yyyy-MM-dd");
                        }
                    }
                }

                return Ok(app.GetExamenes(lParam));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/materias")]
        public IActionResult GetMaterias()
        {
            try
            {
                return Ok(app.GetMaterias());
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/docentesExamen")]
        public IActionResult GetDocentesExamenes([FromQuery(Name = "materia")] int idMateria)
        {
            try
            {
                if (idMateria <= 0)
                {
                    return BadRequest("El parámetro 'materia' debe ser un valor positivo.");
                }

                List<Parametro> lParam = new List<Parametro>
                {
                     new Parametro { Nombre = "@materia", Valor = idMateria }
                };

                var docentes = app.GetDocentesExamen(lParam);
                return Ok(docentes);
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }

        [HttpGet("/alumnosexamen")]
        public IActionResult GetAlumnosExamenes([FromQuery(Name = "materia")] int idMateria)
        {
            try
            {
                if (idMateria <= 0)
                {
                    return BadRequest("El parámetro 'materia' debe ser un valor positivo.");
                }

                List<Parametro> lParam = new List<Parametro>
                {
                    new Parametro { Nombre = "@id_materia", Valor = idMateria }
                };

                return Ok(app.GetAlumnosExamen(lParam));
            }
            catch
            {
                return StatusCode(500, "Error interno. Intente más tarde");
            }
        }
    }
}
