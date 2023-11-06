using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class DetalleAlumnoExamen
    {
        public int IdDetalleAlumnoExamen { get; set; }
        public Alumno AlumnoDetalle { get; set; }
        public int NotaDetalle { get; set; }

        public DetalleAlumnoExamen()
        {
            IdDetalleAlumnoExamen = 0;
            AlumnoDetalle = new Alumno();
            NotaDetalle = 0;
        }

        public DetalleAlumnoExamen(int id, Alumno alum, int nota)
        {
            IdDetalleAlumnoExamen = id;
            AlumnoDetalle = alum;
            NotaDetalle = nota;
        }
    }
}