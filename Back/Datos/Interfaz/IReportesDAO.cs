using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Back.Dominio;

namespace Back.Datos.Interfaz
{
    internal interface IReportesDAO
    {
        public List<Tecnicatura> TraerTecnicaturas();
        public List<Comision> TraerComisiones();
    }
}
