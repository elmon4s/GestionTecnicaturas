using Back.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back.Dominio
{
    public class Examen
    {
        public int IdExamen { get; set; }
        public DateTime FechaExamen { get; set; }
        public Materia MateriaExamen { get; set; }
        public Docente DocenteExamen { get; set; }
        public List<DetalleAlumnoExamen> DetallesExamen { get; set; }

        public Examen()
        {
            IdExamen = 0;
            FechaExamen = DateTime.MinValue;
            MateriaExamen = new Materia();
            DocenteExamen = new Docente();
            DetallesExamen = new List<DetalleAlumnoExamen>();
        }

        public Examen(int id, DateTime fec, Materia mat, Docente doc, List<DetalleAlumnoExamen> det)
        {
            IdExamen = id;
            FechaExamen = fec;
            MateriaExamen = mat;
            DocenteExamen = doc;
            DetallesExamen = det;
        }

        public void AgregarDetalle(DetalleAlumnoExamen detalle)
        {
            DetallesExamen.Add(detalle);
        }

        public void QuitarDetalle(int posicion)
        {
            DetallesExamen.RemoveAt(posicion);
        }

        public double CalcularPromedio()
        {
            double aux = 0;
            foreach (DetalleAlumnoExamen det in DetallesExamen)
            {
                aux += det.NotaDetalle;
            }
            return aux / DetallesExamen.Count();
        }
    }
}