using Back.Datos.Interfaz;
using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Implementacion
{
    public class ExamenesDAO:IExamenesDAO
    {
        public int ObtenerProximoExamen()
        {
            throw new NotImplementedException();
        }
        public bool ConfirmarExamen(Examen oExamen)
        {
            throw new NotImplementedException();

        }
        public bool ActualizarExamen(Examen oExamen)
        {
            throw new NotImplementedException();

        }
        public bool BorrarExamen(int nroExamen)
        {
            throw new NotImplementedException();

        }
        public Examen TraerExamen(int nroExamen)
        {
            throw new NotImplementedException();

        }
        public List<Examen> TraerExamenes(List<Parametro> lParam)
        {
            throw new NotImplementedException();

        }
        public List<Materia> TraerMaterias()
        {
            throw new NotImplementedException();

        }
        public List<Docente> TraerDocentesExamen(List<Parametro> lParam)
        {
            throw new NotImplementedException();

        }
        public List<Alumno> TraerAlumnosExamen(List<Parametro> lParam)
        {
            throw new NotImplementedException();

        }
    }
}
