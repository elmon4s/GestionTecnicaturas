using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class DetalleAlumnoMateria
    {
        public int IdDetalleAlumnoMateria { get; set; }
        public DetalleMateriaComision DetalleMateriaComision { get; set; }
        public EstadoAcademico EstadoDetalle { get; set; }
        public DateTime FechaInscripcionDetalle { get; set; }
        public DateTime FechaEstadoDetalle { get; set; }
        public List<Evaluacion> EvaluacionesDetalle { get; set; }

        public DetalleAlumnoMateria()
        {
            IdDetalleAlumnoMateria = 0;
            DetalleMateriaComision = new DetalleMateriaComision();
            EstadoDetalle = new EstadoAcademico();
            FechaInscripcionDetalle = DateTime.MinValue;
            FechaEstadoDetalle = DateTime.Now;
            EvaluacionesDetalle = new List<Evaluacion>();
        }

        public DetalleAlumnoMateria(int id, DetalleMateriaComision det, EstadoAcademico est, DateTime insc, DateTime fecEst, List<Evaluacion> lEvaluaciones)
        {
            IdDetalleAlumnoMateria = id;
            DetalleMateriaComision = det;
            EstadoDetalle = est;
            FechaInscripcionDetalle = insc;
            FechaEstadoDetalle = fecEst;
            EvaluacionesDetalle = lEvaluaciones;
        }

        public void AgregarDetalle(Evaluacion eval)
        {
            EvaluacionesDetalle.Add(eval);
        }

        public void QuitarDetalle(int posicion)
        {
            EvaluacionesDetalle.RemoveAt(posicion);
        }

        public double CalcularPromedio()
        {
            double aux = 0;
            foreach (Evaluacion ev in EvaluacionesDetalle)
            {
                aux += ev.Nota;
            }
            return aux / EvaluacionesDetalle.Count();
        }
    }
}
