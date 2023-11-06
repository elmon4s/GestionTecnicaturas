using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class SituacionLaboral
    {
        public int IdSituacion { get; set; }
        public string Situacion { get; set; }

        public SituacionLaboral()
        {
            IdSituacion = 0;
            Situacion = string.Empty;
        }

        public SituacionLaboral(int id, string sit)
        {
            IdSituacion = id;
            Situacion = sit;
        }

        public override string ToString()
        {
            return Situacion;
        }
    }
}