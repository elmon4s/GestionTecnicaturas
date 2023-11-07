using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class DetalleMateriaComision
    {
        public int IdDetalleMateriaComision { get; set; }
        public Docente DocenteMateriaComision { get; set; }
        public Materia MateriaDetalle { get; set; }
        public Comision ComisionDetalle { get; set; }
        public int AñoLectivoDetalle { get; set; }

        public DetalleMateriaComision()
        {
            IdDetalleMateriaComision = 0;
            DocenteMateriaComision = new Docente();
            MateriaDetalle = new Materia();
            ComisionDetalle = new Comision();
            AñoLectivoDetalle = 0;
        }

        public DetalleMateriaComision(int id, Docente doc, Materia mat, Comision com, int año)
        {
            IdDetalleMateriaComision = id;
            DocenteMateriaComision = doc;
            MateriaDetalle = mat;
            ComisionDetalle = com;
            AñoLectivoDetalle = año;
        }
    }
}