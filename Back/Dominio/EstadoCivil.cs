using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class EstadoCivil
    {
        public int IdEstadoCivil { get; set; }
        public string DescripcionEstadoCivil { get; set; }

        public EstadoCivil()
        {
            IdEstadoCivil = 0;
            DescripcionEstadoCivil = string.Empty;
        }
        public EstadoCivil(int id, string desc)
        {
            IdEstadoCivil = id;
            DescripcionEstadoCivil = desc;
        }

        public override string ToString()
        {
            return DescripcionEstadoCivil;
        }
    }
}