using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Materia
    {
        public int IdMateria { get; set; }
        public string NombreMateria { get; set; }
        public Tecnicatura TecnicaturaMateria { get; set; }

        public Materia()
        {
            IdMateria = 0;
            NombreMateria = string.Empty;
            TecnicaturaMateria = new Tecnicatura();
        }
        public Materia(int id, string nom, Tecnicatura tec)
        {
            IdMateria = id;
            NombreMateria = nom;
            TecnicaturaMateria = tec;
        }

        public override string ToString()
        {
            return NombreMateria;
        }
    }
}