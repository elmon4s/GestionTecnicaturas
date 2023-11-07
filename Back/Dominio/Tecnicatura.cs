using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Tecnicatura
    {
        public int IdTecnicatura { get; set; }
        public string NombreTecnicatura { get; set; }
        public string TituloTecnicatura { get; set; }

        public Tecnicatura()
        {
            IdTecnicatura = 0;
            NombreTecnicatura = string.Empty;
            TituloTecnicatura = string.Empty;
        }

        public Tecnicatura(int id, string nom, string tit)
        {
            IdTecnicatura = id;
            NombreTecnicatura = nom;
            TituloTecnicatura = tit;
        }

        public override string ToString()
        {
            return NombreTecnicatura;
        }
    }
}