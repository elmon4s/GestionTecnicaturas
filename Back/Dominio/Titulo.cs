using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class Titulo
    {
        public int IdTitulo { get; set; }
        public string DescripcionTitulo { get; set; }

        public Titulo()
        {
            IdTitulo = 0;
            DescripcionTitulo = string.Empty;
        }

        public Titulo(int id, string desc)
        {
            IdTitulo = id;
            DescripcionTitulo = desc;
        }

        public override string ToString()
        {
            return DescripcionTitulo;
        }
    }
}