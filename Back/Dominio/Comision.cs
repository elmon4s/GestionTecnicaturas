using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Comision
    {
        public int IdComision { get; set; }
        public string DescripcionComision { get; set; }

        public Comision()
        {
            IdComision = 0;
            DescripcionComision = string.Empty;
        }
        public Comision(int id, string desc)
        {
            IdComision = id;
            DescripcionComision = desc;
        }

        public override string ToString()
        {
            return DescripcionComision;
        }
    }
}