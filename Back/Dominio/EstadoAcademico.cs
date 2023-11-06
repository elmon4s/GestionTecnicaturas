using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    internal class EstadoAcademico
    {
        public int IdEstadoAcademico { get; set; }
        public string DescEstadoAcademico { get; set; }
        public EstadoAcademico()
        {
            IdEstadoAcademico = 0;
            DescEstadoAcademico = string.Empty;
        }
        public EstadoAcademico(int id, string desc)
        {
            IdEstadoAcademico = id;
            DescEstadoAcademico = desc;
        }

        public override string ToString()
        {
            return DescEstadoAcademico;
        }
    }
}
