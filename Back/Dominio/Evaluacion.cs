using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class Evaluacion
    {
        public int IdEvaluacion { get; set; }
        public DateTime FechaEvaluacion { get; set; }
        public TipoEvaluacion TipoEvaluacion { get; set; }
        public int Nota { get; set; }

        public Evaluacion()
        {
            IdEvaluacion = 0;
            FechaEvaluacion = DateTime.Now;
            TipoEvaluacion = new TipoEvaluacion();
            Nota = 0;
        }

        public Evaluacion(int id, DateTime fecha, TipoEvaluacion tipo, int nota)
        {
            IdEvaluacion = id;
            FechaEvaluacion = fecha;
            TipoEvaluacion = tipo;
            Nota = nota;
        }

    }
}