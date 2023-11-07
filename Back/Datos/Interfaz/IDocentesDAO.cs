using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Datos.Interfaz
{
    internal interface IDocentesDAO
    {
        public bool CrearDocente(Docente oDocente);
        public bool ActualizarDocente(Docente oDocente);
        public bool BorrarDocente(int nroDocente);
        public List<Docente> TraerDocentes(List<Parametro> lParam);
        public Docente TraerDocente(int nroDocente);
        public List<Titulo> TraerTitulos();
        public List<Barrio> TraerBarrios();
    }
}
