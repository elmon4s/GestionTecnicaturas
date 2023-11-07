using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Ciudad
    {
        public int IdCiudad { get; set; }
        public string NombreCiudad { get; set; }

        public Ciudad()
        {
            IdCiudad = 0;
            NombreCiudad = string.Empty;
        }

        public Ciudad(int id, string nom)
        {
            IdCiudad = id;
            NombreCiudad = nom;
        }

        public override string ToString()
        {
            return NombreCiudad;
        }
    }
}