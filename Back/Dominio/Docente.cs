using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Docente : Persona
    {
        private int codDocente;

        public int IdDocente { get; set; }
        public Titulo TituloDocente { get; set; }

        public Docente() : base()
        {
            IdDocente = 0;
            TituloDocente = new Titulo();
        }
        public Docente(int id, Titulo titulo, string nom, string ape, string dir,
            int alt, string tel, string email, Barrio barrio) : base(nom, ape, dir, alt, tel, email, barrio)
        {
            IdDocente = id;
            TituloDocente = titulo;
        }

        public Docente(int codDocente)
        {
            this.codDocente = codDocente;
        }

        public override string ToString()
        {
            return Nombre + " " + Apellido;
        }
    }
}