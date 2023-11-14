using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Interfaz
{
    public interface IAlumnosDAO
    {
        public bool ConfirmarAlumno(Alumno oAlumno);
        public bool ActualizarAlumno(Alumno oAlumno);
        public bool BorrarAlumno(int nroAlumno);
        public Alumno TraerAlumno(int nroAlumno);
        public List<Alumno> TraerAlumnos(List<Parametro> lParam);
        public List<Barrio> TraerBarrios();
        public List<SituacionLaboral> TraerSituacionesLaborales();
        public List<EstadoCivil> TraerEstadosCiviles();
        public List<DetalleMateriaComision> TraerMateriaComision(List<Parametro> lParam);
        public List<DetalleMateriaComision> TraerMateriaComisionFiltrado(List<Parametro> lParam);
        public List<EstadoAcademico> TraerEstadosAcademicos();
    }
}
