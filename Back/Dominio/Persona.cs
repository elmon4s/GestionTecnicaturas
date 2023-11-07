using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Altura { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Barrio Barrio { get; set; }

        public Persona()
        {
            Nombre = string.Empty;
            Apellido = string.Empty;
            Direccion = string.Empty;
            Altura = 0;
            Telefono = string.Empty;
            Email = string.Empty;
            Barrio = new Barrio();
        }

        public Persona(string nom, string ape, string dir, int alt, string tel, string email, Barrio barrio)
        {
            Nombre = nom;
            Apellido = ape;
            Direccion = dir;
            Altura = alt;
            Telefono = tel;
            Email = email;
            Barrio = barrio;
        }
    }
}