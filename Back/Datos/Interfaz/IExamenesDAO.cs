using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Interfaz
{
    public interface IExamenesDAO
    {
        public int ObtenerProximoExamen();
        public bool ConfirmarExamen(Examen oExamen);
        public bool ActualizarExamen(Examen oExamen);
        public bool BorrarExamen(int nroExamen);
        public Examen TraerExamen(int nroExamen);
        public List<Examen> TraerExamenes(List<Parametro> lParam);
        public List<Materia> TraerMaterias();
        public List<Docente> TraerDocentesExamen(List<Parametro> lParam);
        public List<Alumno> TraerAlumnosExamen(List<Parametro> lParam);
    }
}
