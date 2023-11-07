using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Alumno : Persona
    {
        public int IdAlumno { get; set; }
        public SituacionLaboral SituacionAlumno { get; set; }
        public EstadoCivil EstadoCivilAlumno { get; set; }
        public List<DetalleAlumnoMateria> DetallesAlumno { get; set; }

        public Alumno() : base()
        {
            IdAlumno = 0;
            SituacionAlumno = new SituacionLaboral();
            EstadoCivilAlumno = new EstadoCivil();
            DetallesAlumno = new List<DetalleAlumnoMateria>();
        }

        public Alumno(int id, SituacionLaboral sit, EstadoCivil est, List<DetalleAlumnoMateria> lDetalles, string nom, string ape, string dir,
            int alt, string tel, string email, Barrio barrio) : base(nom, ape, dir, alt, tel, email, barrio)
        {
            IdAlumno = id;
            SituacionAlumno = sit;
            EstadoCivilAlumno = est;
            DetallesAlumno = lDetalles;
        }


    }
}